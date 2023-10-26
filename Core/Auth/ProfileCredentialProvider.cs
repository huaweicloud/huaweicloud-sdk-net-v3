using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HuaweiCloud.SDK.Core.Auth
{
    public class ProfileCredentialProvider : ICredentialProvider
    {

        private const string CredentialsFileEnvName = "HUAWEICLOUD_SDK_CREDENTIALS_FILE";
        private readonly string _credentialType;

        public ProfileCredentialProvider(string credentialType)
        {
            _credentialType = credentialType.ToLower();
        }

        public static ProfileCredentialProvider GetBasic()
        {
            return new ProfileCredentialProvider(BasicCredentials.Type);
        }

        public static ProfileCredentialProvider GetGlobal()
        {
            return new ProfileCredentialProvider(GlobalCredentials.Type);
        }

        public ICredential GetCredentials()
        {
            if (string.IsNullOrEmpty(_credentialType))
            {
                throw new SdkException("credential type is empty");
            }

            var filepath = GetCredentialsFilepath();
            if (!File.Exists(filepath))
            {
                throw new SdkException($"file {filepath} does not exist");
            }

            var lines = ReadLines(filepath, true);

            var dict = ProcessCredentialsDict(lines);

            var ak = GetValue(dict, _credentialType + "ak");
            var sk = GetValue(dict, _credentialType + "sk");
            var projectId = GetValue(dict, _credentialType + "project_id");
            var domainId = GetValue(dict, _credentialType + "domain_id");
            var securityToken = GetValue(dict, _credentialType + "security_token");
            var iamEndPoint = GetValue(dict, _credentialType + "iam_endpoint");

            if (string.IsNullOrEmpty(ak) || string.IsNullOrEmpty(sk))
            {
                throw new SdkException("ak or sk does not exist in profile");
            }

            if (_credentialType.StartsWith(BasicCredentials.Type))
            {
                var credentials = new BasicCredentials(ak, sk, projectId).WithSecurityToken(securityToken);
                if (!string.IsNullOrEmpty(iamEndPoint))
                {
                    credentials.WithIamEndpoint(iamEndPoint);
                }
                return credentials;
            }
            else if (_credentialType.StartsWith(GlobalCredentials.Type))
            {
                var credentials = new GlobalCredentials(ak, sk, domainId).WithSecurityToken(securityToken);
                if (!string.IsNullOrEmpty(iamEndPoint))
                {
                    credentials.WithIamEndpoint(iamEndPoint);
                }
                return credentials;
            }

            throw new SdkException("unsupported credential type: " + _credentialType);
        }

        private static Dictionary<string, string> ProcessCredentialsDict(List<string> lines)
        {
            var dict = new Dictionary<string, string>();
            var section = "";
            foreach (var line in lines)
            {
                if (line.Contains('='))
                {
                    var parts = line.Split(new[]
                    {
                        '='
                    }, 2);
                    if (parts.Length == 2)
                    {
                        dict.Add(section + parts[0].TrimEnd(), parts[1].TrimStart());
                    }
                }
                else if (line.StartsWith("[") && line.EndsWith("]"))
                {
                    section = line.TrimStart('[').TrimEnd(']');
                }
            }
            return dict;
        }

        private List<string> ReadLines(string filepath, bool trim = false)
        {
            var lines = new List<string>();
            using (var reader = new StreamReader(filepath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var processedLine = trim ? line.Trim() : line;
                    if (!string.IsNullOrEmpty(processedLine))
                    {
                        lines.Add(processedLine);
                    }
                }
            }
            return lines;
        }

        private static string GetValue(Dictionary<string, string> dict, string key)
        {
            return dict.ContainsKey(key) ? dict[key] : null;
        }

        private static string GetCredentialsFilepath()
        {
            var credentialsFile = Environment.GetEnvironmentVariable(CredentialsFileEnvName);
            if (!string.IsNullOrEmpty(credentialsFile))
            {
                return credentialsFile;
            }

            var homePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return Path.Combine(homePath, Constants.DefaultProfileDirName, "credentials");
        }
    }
}
