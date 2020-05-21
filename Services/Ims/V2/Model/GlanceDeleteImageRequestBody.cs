using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 请求参数
    /// </summary>
    public class GlanceDeleteImageRequestBody 
    {

        /// <summary>
        /// 取值为：true和false true：表示删除整机镜像时，同时删除其关联的云服务器备份。 false：表示只删除整机镜像，不删除其关联的云服务器备份。
        /// </summary>
        [JsonProperty("delete_backup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteBackup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlanceDeleteImageRequestBody {\n");
            sb.Append("  deleteBackup: ").Append(DeleteBackup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlanceDeleteImageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlanceDeleteImageRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeleteBackup == input.DeleteBackup ||
                    (this.DeleteBackup != null &&
                    this.DeleteBackup.Equals(input.DeleteBackup))
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
                if (this.DeleteBackup != null)
                    hashCode = hashCode * 59 + this.DeleteBackup.GetHashCode();
                return hashCode;
            }
        }
    }
}
