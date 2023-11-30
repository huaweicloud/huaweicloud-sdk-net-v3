using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V3.Model
{
    /// <summary>
    /// 文档数据输入
    /// </summary>
    public class DocumentCreateRequestData 
    {

        /// <summary>
        /// 文档url。目前支持：公网HTTP/HTTPS URL。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 文档格式。可选值： docx pdf doc xls xlsx ppt pptx pps ppsx xltx xltm xlsb xlsm txt csv epub webpage 若format与文档实际格式不一致，则返回报错参数错误
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// 当需要审核网页视频时，视频截帧频率间隔，单位为秒，取值范围为1~60s；若不传递默认5s截帧一次
        /// </summary>
        [JsonProperty("frame_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameInterval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentCreateRequestData {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  frameInterval: ").Append(FrameInterval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentCreateRequestData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DocumentCreateRequestData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.FrameInterval == input.FrameInterval ||
                    (this.FrameInterval != null &&
                    this.FrameInterval.Equals(input.FrameInterval))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.FrameInterval != null)
                    hashCode = hashCode * 59 + this.FrameInterval.GetHashCode();
                return hashCode;
            }
        }
    }
}
