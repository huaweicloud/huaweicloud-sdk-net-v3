using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Demo.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ArrayItem 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("itme1", NullValueHandling = NullValueHandling.Ignore)]
        public string Itme1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("itme2", NullValueHandling = NullValueHandling.Ignore)]
        public string Itme2 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArrayItem {\n");
            sb.Append("  itme1: ").Append(Itme1).Append("\n");
            sb.Append("  itme2: ").Append(Itme2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ArrayItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ArrayItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Itme1 == input.Itme1 ||
                    (this.Itme1 != null &&
                    this.Itme1.Equals(input.Itme1))
                ) && 
                (
                    this.Itme2 == input.Itme2 ||
                    (this.Itme2 != null &&
                    this.Itme2.Equals(input.Itme2))
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
                if (this.Itme1 != null)
                    hashCode = hashCode * 59 + this.Itme1.GetHashCode();
                if (this.Itme2 != null)
                    hashCode = hashCode * 59 + this.Itme2.GetHashCode();
                return hashCode;
            }
        }
    }
}
