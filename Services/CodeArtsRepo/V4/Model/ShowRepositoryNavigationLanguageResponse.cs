using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRepositoryNavigationLanguageResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 结果标识。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// **参数解释：** 结果消息。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// **参数解释：** 语言列表。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("language_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<LanguageDto> LanguageList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepositoryNavigationLanguageResponse {\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  languageList: ").Append(LanguageList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepositoryNavigationLanguageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepositoryNavigationLanguageResponse input)
        {
            if (input == null) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.LanguageList != input.LanguageList || (this.LanguageList != null && input.LanguageList != null && !this.LanguageList.SequenceEqual(input.LanguageList))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.LanguageList != null) hashCode = hashCode * 59 + this.LanguageList.GetHashCode();
                return hashCode;
            }
        }
    }
}
