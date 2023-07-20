using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// flavor规格信息。
    /// </summary>
    public class MysqlFlavorInfo 
    {

        /// <summary>
        /// CPU核数。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string Vcpus { get; set; }

        /// <summary>
        /// 内存大小，单位GB。
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public string Ram { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlFlavorInfo {\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlFlavorInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlFlavorInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Vcpus == input.Vcpus ||
                    (this.Vcpus != null &&
                    this.Vcpus.Equals(input.Vcpus))
                ) && 
                (
                    this.Ram == input.Ram ||
                    (this.Ram != null &&
                    this.Ram.Equals(input.Ram))
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
                if (this.Vcpus != null)
                    hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Ram != null)
                    hashCode = hashCode * 59 + this.Ram.GetHashCode();
                return hashCode;
            }
        }
    }
}
