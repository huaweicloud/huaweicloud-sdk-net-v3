using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowEventDataRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("dim.0", IsQuery = true)]
        public string Dim0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("dim.1", IsQuery = true)]
        public string Dim1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("dim.2", IsQuery = true)]
        public string Dim2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("from", IsQuery = true)]
        public long? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("to", IsQuery = true)]
        public long? To { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        public string Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEventDataRequest {\n");
            sb.Append("  dim0: ").Append(Dim0).Append("\n");
            sb.Append("  dim1: ").Append(Dim1).Append("\n");
            sb.Append("  dim2: ").Append(Dim2).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEventDataRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEventDataRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dim0 == input.Dim0 ||
                    (this.Dim0 != null &&
                    this.Dim0.Equals(input.Dim0))
                ) && 
                (
                    this.Dim1 == input.Dim1 ||
                    (this.Dim1 != null &&
                    this.Dim1.Equals(input.Dim1))
                ) && 
                (
                    this.Dim2 == input.Dim2 ||
                    (this.Dim2 != null &&
                    this.Dim2.Equals(input.Dim2))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Dim0 != null)
                    hashCode = hashCode * 59 + this.Dim0.GetHashCode();
                if (this.Dim1 != null)
                    hashCode = hashCode * 59 + this.Dim1.GetHashCode();
                if (this.Dim2 != null)
                    hashCode = hashCode * 59 + this.Dim2.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
