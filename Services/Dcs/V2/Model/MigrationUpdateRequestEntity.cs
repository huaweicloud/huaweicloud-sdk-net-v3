using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 迁移更新请求体
    /// </summary>
    public class MigrationUpdateRequestEntity 
    {

        /// <summary>
        /// 模式
        /// </summary>
        [JsonProperty("resume_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ResumeMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationUpdateRequestEntity {\n");
            sb.Append("  resumeMode: ").Append(ResumeMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrationUpdateRequestEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrationUpdateRequestEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResumeMode == input.ResumeMode ||
                    (this.ResumeMode != null &&
                    this.ResumeMode.Equals(input.ResumeMode))
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
                if (this.ResumeMode != null)
                    hashCode = hashCode * 59 + this.ResumeMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
