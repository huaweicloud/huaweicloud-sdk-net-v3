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
    /// Response Object
    /// </summary>
    public class ShowInformationAboutDatabaseProxyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("proxy", NullValueHandling = NullValueHandling.Ignore)]
        public Proxy Proxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("master_instance", NullValueHandling = NullValueHandling.Ignore)]
        public MasterInstance MasterInstance { get; set; }

        /// <summary>
        /// 只读实例信息。
        /// </summary>
        [JsonProperty("readonly_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReadonlyInstances> ReadonlyInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInformationAboutDatabaseProxyResponse {\n");
            sb.Append("  proxy: ").Append(Proxy).Append("\n");
            sb.Append("  masterInstance: ").Append(MasterInstance).Append("\n");
            sb.Append("  readonlyInstances: ").Append(ReadonlyInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInformationAboutDatabaseProxyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInformationAboutDatabaseProxyResponse input)
        {
            if (input == null) return false;
            if (this.Proxy != input.Proxy || (this.Proxy != null && !this.Proxy.Equals(input.Proxy))) return false;
            if (this.MasterInstance != input.MasterInstance || (this.MasterInstance != null && !this.MasterInstance.Equals(input.MasterInstance))) return false;
            if (this.ReadonlyInstances != input.ReadonlyInstances || (this.ReadonlyInstances != null && input.ReadonlyInstances != null && !this.ReadonlyInstances.SequenceEqual(input.ReadonlyInstances))) return false;

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
                if (this.Proxy != null) hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                if (this.MasterInstance != null) hashCode = hashCode * 59 + this.MasterInstance.GetHashCode();
                if (this.ReadonlyInstances != null) hashCode = hashCode * 59 + this.ReadonlyInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
