using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PostgresqlHbaHistory 
    {

        /// <summary>
        /// 修改结果，    success：已生效     failed：未生效     setting：设置中\&quot;,
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// 修改失败原因
        /// </summary>
        [JsonProperty("fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailReason { get; set; }

        /// <summary>
        /// 修改之前的值
        /// </summary>
        [JsonProperty("before_confs", NullValueHandling = NullValueHandling.Ignore)]
        public List<PostgresqlHbaConf> BeforeConfs { get; set; }

        /// <summary>
        /// 修改之后的值
        /// </summary>
        [JsonProperty("after_confs", NullValueHandling = NullValueHandling.Ignore)]
        public List<PostgresqlHbaConf> AfterConfs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostgresqlHbaHistory {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  failReason: ").Append(FailReason).Append("\n");
            sb.Append("  beforeConfs: ").Append(BeforeConfs).Append("\n");
            sb.Append("  afterConfs: ").Append(AfterConfs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostgresqlHbaHistory);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostgresqlHbaHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.BeforeConfs == input.BeforeConfs ||
                    this.BeforeConfs != null &&
                    input.BeforeConfs != null &&
                    this.BeforeConfs.SequenceEqual(input.BeforeConfs)
                ) && 
                (
                    this.AfterConfs == input.AfterConfs ||
                    this.AfterConfs != null &&
                    input.AfterConfs != null &&
                    this.AfterConfs.SequenceEqual(input.AfterConfs)
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.FailReason != null)
                    hashCode = hashCode * 59 + this.FailReason.GetHashCode();
                if (this.BeforeConfs != null)
                    hashCode = hashCode * 59 + this.BeforeConfs.GetHashCode();
                if (this.AfterConfs != null)
                    hashCode = hashCode * 59 + this.AfterConfs.GetHashCode();
                return hashCode;
            }
        }
    }
}
