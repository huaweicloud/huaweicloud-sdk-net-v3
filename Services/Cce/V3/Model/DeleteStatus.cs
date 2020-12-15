using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteStatus 
    {

        /// <summary>
        /// 集群删除时更新的资源记录总数
        /// </summary>
        [JsonProperty("added", NullValueHandling = NullValueHandling.Ignore)]
        public int? Added { get; set; }

        /// <summary>
        /// 基于当前集群资源记录信息，生成实际最新资源记录总数
        /// </summary>
        [JsonProperty("current_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentTotal { get; set; }

        /// <summary>
        /// 集群删除时删除的资源记录总数
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deleted { get; set; }

        /// <summary>
        /// 集群删除时已经存在的集群资源记录总数
        /// </summary>
        [JsonProperty("previous_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreviousTotal { get; set; }

        /// <summary>
        /// 集群删除时更新的资源记录总数
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public int? Updated { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteStatus {\n");
            sb.Append("  added: ").Append(Added).Append("\n");
            sb.Append("  currentTotal: ").Append(CurrentTotal).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  previousTotal: ").Append(PreviousTotal).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Added == input.Added ||
                    (this.Added != null &&
                    this.Added.Equals(input.Added))
                ) && 
                (
                    this.CurrentTotal == input.CurrentTotal ||
                    (this.CurrentTotal != null &&
                    this.CurrentTotal.Equals(input.CurrentTotal))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
                ) && 
                (
                    this.PreviousTotal == input.PreviousTotal ||
                    (this.PreviousTotal != null &&
                    this.PreviousTotal.Equals(input.PreviousTotal))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
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
                if (this.Added != null)
                    hashCode = hashCode * 59 + this.Added.GetHashCode();
                if (this.CurrentTotal != null)
                    hashCode = hashCode * 59 + this.CurrentTotal.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.PreviousTotal != null)
                    hashCode = hashCode * 59 + this.PreviousTotal.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                return hashCode;
            }
        }
    }
}
