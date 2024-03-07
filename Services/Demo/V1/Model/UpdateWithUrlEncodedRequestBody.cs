using System;
using System.Collections.Generic;
using System.IO;
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
    public class UpdateWithUrlEncodedRequestBody : IFormDataBody
    {

        /// <summary>
        /// Updated name of the pet
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Updated age of the pet
        /// </summary>
        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public int? Age { get; set; }


        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("name", new FormDataPart<string>(Name));
            if (Age != null) {
                formData.Add("age", new FormDataPart<int?>(Age));
            }

            return formData;
        }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWithUrlEncodedRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  age: ").Append(Age).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateWithUrlEncodedRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateWithUrlEncodedRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Age == input.Age ||
                    (this.Age != null &&
                    this.Age.Equals(input.Age))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Age != null)
                    hashCode = hashCode * 59 + this.Age.GetHashCode();
                return hashCode;
            }
        }
    }
}
