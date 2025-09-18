using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 支持的大区。
    /// </summary>
    public class Area 
    {

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 大区ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 大区英文名称。
        /// </summary>
        [JsonProperty("en_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnName { get; set; }

        /// <summary>
        /// 大区西语名称。
        /// </summary>
        [JsonProperty("es_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EsName { get; set; }

        /// <summary>
        /// 大区葡语名称。
        /// </summary>
        [JsonProperty("pt_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PtName { get; set; }

        /// <summary>
        /// 站点。
        /// </summary>
        [JsonProperty("station", NullValueHandling = NullValueHandling.Ignore)]
        public string Station { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Area {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  enName: ").Append(EnName).Append("\n");
            sb.Append("  esName: ").Append(EsName).Append("\n");
            sb.Append("  ptName: ").Append(PtName).Append("\n");
            sb.Append("  station: ").Append(Station).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Area);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Area input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.EnName != input.EnName || (this.EnName != null && !this.EnName.Equals(input.EnName))) return false;
            if (this.EsName != input.EsName || (this.EsName != null && !this.EsName.Equals(input.EsName))) return false;
            if (this.PtName != input.PtName || (this.PtName != null && !this.PtName.Equals(input.PtName))) return false;
            if (this.Station != input.Station || (this.Station != null && !this.Station.Equals(input.Station))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EnName != null) hashCode = hashCode * 59 + this.EnName.GetHashCode();
                if (this.EsName != null) hashCode = hashCode * 59 + this.EsName.GetHashCode();
                if (this.PtName != null) hashCode = hashCode * 59 + this.PtName.GetHashCode();
                if (this.Station != null) hashCode = hashCode * 59 + this.Station.GetHashCode();
                return hashCode;
            }
        }
    }
}
