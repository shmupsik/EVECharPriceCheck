using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EVECharPriceCheck
{
    class EveBoardApi
    {


        public static SkillDataResponse GetSkillBooksList(string url, string pass)
        {
            string SkillsPattern = @"<td height=""20"" class=""dotted"" style=""[^>]+>(?:<span style=""color: #[0-9a-fA-F]{6};"">){0,2}(?<Skill>[^\/]+)\s\/[^\/]+[^\/]+\/[^\/]+\/[^\/<]+<\/";
            string SPPattern = @"<td height=""15"" align=""left"" bgcolor=""#000000"">Skill points<\/td>.*?<td align=""left"" bgcolor=""#000000"">(?<SkillPoints>[^<]+)<\/td>";
            string ErrorKeyPattern = @"<td height=""25"" align=""center"" bgcolor=""#FF0000"" style=""border: solid 2px #ffffff;""><span style=""font-size: 12px; font-weight: bold;"">(?<ErrorText>[^<]+)";
            string RestrictedPattern = @"<td align=""center"" valign=""top"">The access to this character is restricted, please enter the password to continue<br />";
            string UnallocatedPattern = @"<td align=""left"" bgcolor=""#000000"">Unallocated<\/td>.*?<td align=""left"" bgcolor=""#000000"">(?<Unallocated>[^<]+)<\/td>";

            SkillDataResponse result = new SkillDataResponse();

            using (var webClient = new WebClient())
            {

                try
                {
                    var responseString = webClient.DownloadString(url);

                    if (Regex.IsMatch(responseString, RestrictedPattern))
                    {
                        result.IsRestricted = true;

                        if (!String.IsNullOrEmpty(pass))
                        {
                            NameValueCollection values = new NameValueCollection();
                            values.Add("pw", pass);

                            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                            byte[] res = webClient.UploadValues(url, "POST", values);
                            responseString = Encoding.UTF8.GetString(res);
                        }
                    }

                    result.SkillsList = Regex.Matches(responseString, SkillsPattern).Cast<Match>().Select(m => m.Groups["Skill"].Value).ToArray();

                    Debug.WriteLine(String.Format("Skill count: {0}", result.SkillsList.Count()));


                    Match match = Regex.Match(responseString, SPPattern, RegexOptions.Singleline);
                    if (match.Success)
                    {
                        result.TotalSkillPoints = int.Parse(match.Groups["SkillPoints"].Value.Replace(",", ""));
                    }

                    match = Regex.Match(responseString, UnallocatedPattern, RegexOptions.Singleline);
                    if (match.Success)
                    {
                        result.UnallocatedSkillPoints = int.Parse(match.Groups["Unallocated"].Value.Replace(",", ""));
                        result.TotalSkillPoints += result.UnallocatedSkillPoints;
                    }

                    result.ApiKeyExpired = Regex.IsMatch(responseString, ErrorKeyPattern);

                    result.IsSuccessful = true;

                }
                catch (WebException e)
                {
                    result.IsSuccessful = false;
                    MessageBox.Show(e.ToString());
                }
                catch (Exception e)
                {
                    result.IsSuccessful = false;
                    MessageBox.Show(e.ToString());
                }

            }

            return result;

        }


    }

}
