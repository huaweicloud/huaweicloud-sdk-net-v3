using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RegionLocales 
    {

        /// <summary>
        /// 区域的中文名称。
        /// </summary>
        [JsonProperty("zh-cn", NullValueHandling = NullValueHandling.Ignore)]
        public string ZhCn { get; set; }

        /// <summary>
        /// 区域的英文名称。
        /// </summary>
        [JsonProperty("en-us", NullValueHandling = NullValueHandling.Ignore)]
        public string EnUs { get; set; }

        /// <summary>
        /// 区域的葡萄牙语名称。
        /// </summary>
        [JsonProperty("pt-br", NullValueHandling = NullValueHandling.Ignore)]
        public string PtBr { get; set; }

        /// <summary>
        /// 区域的美国西班牙语名称。
        /// </summary>
        [JsonProperty("es-us", NullValueHandling = NullValueHandling.Ignore)]
        public string EsUs { get; set; }

        /// <summary>
        /// 区域的西班牙语名称。
        /// </summary>
        [JsonProperty("es-es", NullValueHandling = NullValueHandling.Ignore)]
        public string EsEs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegionLocales {\n");
            sb.Append("  zhCn: ").Append(ZhCn).Append("\n");
            sb.Append("  enUs: ").Append(EnUs).Append("\n");
            sb.Append("  ptBr: ").Append(PtBr).Append("\n");
            sb.Append("  esUs: ").Append(EsUs).Append("\n");
            sb.Append("  esEs: ").Append(EsEs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegionLocales);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegionLocales input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ZhCn == input.ZhCn ||
                    (this.ZhCn != null &&
                    this.ZhCn.Equals(input.ZhCn))
                ) && 
                (
                    this.EnUs == input.EnUs ||
                    (this.EnUs != null &&
                    this.EnUs.Equals(input.EnUs))
                ) && 
                (
                    this.PtBr == input.PtBr ||
                    (this.PtBr != null &&
                    this.PtBr.Equals(input.PtBr))
                ) && 
                (
                    this.EsUs == input.EsUs ||
                    (this.EsUs != null &&
                    this.EsUs.Equals(input.EsUs))
                ) && 
                (
                    this.EsEs == input.EsEs ||
                    (this.EsEs != null &&
                    this.EsEs.Equals(input.EsEs))
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
                if (this.ZhCn != null)
                    hashCode = hashCode * 59 + this.ZhCn.GetHashCode();
                if (this.EnUs != null)
                    hashCode = hashCode * 59 + this.EnUs.GetHashCode();
                if (this.PtBr != null)
                    hashCode = hashCode * 59 + this.PtBr.GetHashCode();
                if (this.EsUs != null)
                    hashCode = hashCode * 59 + this.EsUs.GetHashCode();
                if (this.EsEs != null)
                    hashCode = hashCode * 59 + this.EsEs.GetHashCode();
                return hashCode;
            }
        }
    }
}
