using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DetectLiveFaceByFileResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public LiveDetectFaceRespResult Result { get; set; }

        /// <summary>
        /// 警告信息列表。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("warning-list", NullValueHandling = NullValueHandling.Ignore)]
        public List<WarningList> WarningList { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectLiveFaceByFileResponse {\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  warningList: ").Append(WarningList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectLiveFaceByFileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetectLiveFaceByFileResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.WarningList == input.WarningList ||
                    this.WarningList != null &&
                    input.WarningList != null &&
                    this.WarningList.SequenceEqual(input.WarningList)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.WarningList != null)
                    hashCode = hashCode * 59 + this.WarningList.GetHashCode();
                return hashCode;
            }
        }
    }
}
