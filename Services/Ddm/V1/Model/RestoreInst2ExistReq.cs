using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RestoreInst2ExistReq 
    {

        /// <summary>
        /// 数据恢复源。
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Object Source { get; set; }

        /// <summary>
        /// 数据恢复目标。
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public Object Target { get; set; }

        /// <summary>
        /// 关联dn。
        /// </summary>
        [JsonProperty("data_node_relations", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataNodeRelation> DataNodeRelations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreInst2ExistReq {\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("  dataNodeRelations: ").Append(DataNodeRelations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreInst2ExistReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreInst2ExistReq input)
        {
            if (input == null) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.Target != input.Target || (this.Target != null && !this.Target.Equals(input.Target))) return false;
            if (this.DataNodeRelations != input.DataNodeRelations || (this.DataNodeRelations != null && input.DataNodeRelations != null && !this.DataNodeRelations.SequenceEqual(input.DataNodeRelations))) return false;

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
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Target != null) hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.DataNodeRelations != null) hashCode = hashCode * 59 + this.DataNodeRelations.GetHashCode();
                return hashCode;
            }
        }
    }
}
