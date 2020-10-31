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
    public class ListAlarmTemplatesRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("alarmTemplateId", IsQuery = true)]
        [JsonProperty("alarmTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmTemplateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("dname", IsQuery = true)]
        [JsonProperty("dname", NullValueHandling = NullValueHandling.Ignore)]
        public string Dname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("start", IsQuery = true)]
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public string Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmTemplatesRequest {\n");
            sb.Append("  alarmTemplateId: ").Append(AlarmTemplateId).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  dname: ").Append(Dname).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmTemplatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmTemplatesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmTemplateId == input.AlarmTemplateId ||
                    (this.AlarmTemplateId != null &&
                    this.AlarmTemplateId.Equals(input.AlarmTemplateId))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Dname == input.Dname ||
                    (this.Dname != null &&
                    this.Dname.Equals(input.Dname))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.AlarmTemplateId != null)
                    hashCode = hashCode * 59 + this.AlarmTemplateId.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Dname != null)
                    hashCode = hashCode * 59 + this.Dname.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
