using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTtsAuditionFileResponse : SdkResponse
    {

        /// <summary>
        /// 试听文件是否已生成完成。该标记为false时，应该每隔5秒再次调用本接口获取试听文件。当存在该参数时，将会返回以下message和files两个字段信息
        /// </summary>
        [JsonProperty("is_file_complete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFileComplete { get; set; }

        /// <summary>
        /// 异常信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 试听文件列表。
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuditionFile> Files { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTtsAuditionFileResponse {\n");
            sb.Append("  isFileComplete: ").Append(IsFileComplete).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  files: ").Append(Files).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTtsAuditionFileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTtsAuditionFileResponse input)
        {
            if (input == null) return false;
            if (this.IsFileComplete != input.IsFileComplete || (this.IsFileComplete != null && !this.IsFileComplete.Equals(input.IsFileComplete))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Files != input.Files || (this.Files != null && input.Files != null && !this.Files.SequenceEqual(input.Files))) return false;

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
                if (this.IsFileComplete != null) hashCode = hashCode * 59 + this.IsFileComplete.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Files != null) hashCode = hashCode * 59 + this.Files.GetHashCode();
                return hashCode;
            }
        }
    }
}
