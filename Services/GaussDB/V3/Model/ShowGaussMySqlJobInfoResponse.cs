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
    /// Response Object
    /// </summary>
    public class ShowGaussMySqlJobInfoResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job", NullValueHandling = NullValueHandling.Ignore)]
        public GetJobInfoDetail Job { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGaussMySqlJobInfoResponse {\n");
            sb.Append("  job: ").Append(Job).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGaussMySqlJobInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGaussMySqlJobInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Job == input.Job ||
                    (this.Job != null &&
                    this.Job.Equals(input.Job))
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
                if (this.Job != null)
                    hashCode = hashCode * 59 + this.Job.GetHashCode();
                return hashCode;
            }
        }
    }
}
