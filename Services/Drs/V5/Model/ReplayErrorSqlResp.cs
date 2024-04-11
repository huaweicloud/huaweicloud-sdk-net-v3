using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 回放异常SQL数据项
    /// </summary>
    public class ReplayErrorSqlResp 
    {

        /// <summary>
        /// SQL类型
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// SQL语句
        /// </summary>
        [JsonProperty("abnormal_sql", NullValueHandling = NullValueHandling.Ignore)]
        public string AbnormalSql { get; set; }

        /// <summary>
        /// 异常原因描述
        /// </summary>
        [JsonProperty("abnormal_info", NullValueHandling = NullValueHandling.Ignore)]
        public string AbnormalInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplayErrorSqlResp {\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  abnormalSql: ").Append(AbnormalSql).Append("\n");
            sb.Append("  abnormalInfo: ").Append(AbnormalInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplayErrorSqlResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplayErrorSqlResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.AbnormalSql == input.AbnormalSql ||
                    (this.AbnormalSql != null &&
                    this.AbnormalSql.Equals(input.AbnormalSql))
                ) && 
                (
                    this.AbnormalInfo == input.AbnormalInfo ||
                    (this.AbnormalInfo != null &&
                    this.AbnormalInfo.Equals(input.AbnormalInfo))
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
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.AbnormalSql != null)
                    hashCode = hashCode * 59 + this.AbnormalSql.GetHashCode();
                if (this.AbnormalInfo != null)
                    hashCode = hashCode * 59 + this.AbnormalInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
