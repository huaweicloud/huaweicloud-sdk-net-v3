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
    /// 创建实例，单转主备，创建只读实例时返回。
    /// </summary>
    public class GetJobInfoResponseBodyJobEntitiesInstance 
    {

        /// <summary>
        /// 实例的连接地址。
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// 实例类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public GetJobInfoResponseBodyJobEntitiesInstanceDatastore Datastore { get; set; }

        /// <summary>
        /// 主实例ID，仅创建只读实例的时候返回。
        /// </summary>
        [JsonProperty("replica_of", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicaOf { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetJobInfoResponseBodyJobEntitiesInstance {\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  replicaOf: ").Append(ReplicaOf).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetJobInfoResponseBodyJobEntitiesInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetJobInfoResponseBodyJobEntitiesInstance input)
        {
            if (input == null) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Datastore != input.Datastore || (this.Datastore != null && !this.Datastore.Equals(input.Datastore))) return false;
            if (this.ReplicaOf != input.ReplicaOf || (this.ReplicaOf != null && !this.ReplicaOf.Equals(input.ReplicaOf))) return false;

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
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Datastore != null) hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.ReplicaOf != null) hashCode = hashCode * 59 + this.ReplicaOf.GetHashCode();
                return hashCode;
            }
        }
    }
}
