using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SimpleTagDto 
    {

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 目标commit_id
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gpgKey", NullValueHandling = NullValueHandling.Ignore)]
        public GpgKeyDto GpgKey { get; set; }

        /// <summary>
        /// 是否可以被删除
        /// </summary>
        [JsonProperty("can_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// 是否可以被查看
        /// </summary>
        [JsonProperty("can_read", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanRead { get; set; }

        /// <summary>
        /// 是否可以被下载
        /// </summary>
        [JsonProperty("can_download", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDownload { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleTagDto {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("  gpgKey: ").Append(GpgKey).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canRead: ").Append(CanRead).Append("\n");
            sb.Append("  canDownload: ").Append(CanDownload).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimpleTagDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SimpleTagDto input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Target != input.Target || (this.Target != null && !this.Target.Equals(input.Target))) return false;
            if (this.GpgKey != input.GpgKey || (this.GpgKey != null && !this.GpgKey.Equals(input.GpgKey))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.CanRead != input.CanRead || (this.CanRead != null && !this.CanRead.Equals(input.CanRead))) return false;
            if (this.CanDownload != input.CanDownload || (this.CanDownload != null && !this.CanDownload.Equals(input.CanDownload))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Target != null) hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.GpgKey != null) hashCode = hashCode * 59 + this.GpgKey.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanRead != null) hashCode = hashCode * 59 + this.CanRead.GetHashCode();
                if (this.CanDownload != null) hashCode = hashCode * 59 + this.CanDownload.GetHashCode();
                return hashCode;
            }
        }
    }
}
