using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DetectLiveByUrlIntlResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video-result", NullValueHandling = NullValueHandling.Ignore)]
        public LiveDetectRespVideoresult VideoResult { get; set; }

        /// <summary>
        /// [警告信息列表，WarningList结构见[WarningList](https://support.huaweicloud.com/api-face/face_02_0077.html)。调用失败时无此字段](tag:hc) [警告信息列表，WarningList结构见[WarningList](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0077.html)。调用失败时无此字段](tag:hk)
        /// </summary>
        [JsonProperty("warning-list", NullValueHandling = NullValueHandling.Ignore)]
        public List<WarningList> WarningList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectLiveByUrlIntlResponse {\n");
            sb.Append("  videoResult: ").Append(VideoResult).Append("\n");
            sb.Append("  warningList: ").Append(WarningList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectLiveByUrlIntlResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetectLiveByUrlIntlResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VideoResult == input.VideoResult ||
                    (this.VideoResult != null &&
                    this.VideoResult.Equals(input.VideoResult))
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
                if (this.VideoResult != null)
                    hashCode = hashCode * 59 + this.VideoResult.GetHashCode();
                if (this.WarningList != null)
                    hashCode = hashCode * 59 + this.WarningList.GetHashCode();
                return hashCode;
            }
        }
    }
}
