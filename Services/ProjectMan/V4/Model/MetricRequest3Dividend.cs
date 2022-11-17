using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 指标分子过滤条件
    /// </summary>
    public class MetricRequest3Dividend 
    {

        /// <summary>
        /// 是否按时
        /// </summary>
        [JsonProperty("on_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OnTime { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field16", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField16 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field17", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField17 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field18", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField18 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field19", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField19 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field20", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField20 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field21", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField21 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field22", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField22 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field23", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField23 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field24", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField24 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field25", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField25 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field26", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField26 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field27", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField27 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field28", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField28 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field29", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField29 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field30", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField30 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field31", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField31 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field32", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField32 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field33", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField33 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field34", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField34 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field35", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField35 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field36", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField36 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field37", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField37 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field38", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField38 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field39", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField39 { get; set; }

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field40", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField40 { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricRequest3Dividend {\n");
            sb.Append("  onTime: ").Append(OnTime).Append("\n");
            sb.Append("  customField16: ").Append(CustomField16).Append("\n");
            sb.Append("  customField17: ").Append(CustomField17).Append("\n");
            sb.Append("  customField18: ").Append(CustomField18).Append("\n");
            sb.Append("  customField19: ").Append(CustomField19).Append("\n");
            sb.Append("  customField20: ").Append(CustomField20).Append("\n");
            sb.Append("  customField21: ").Append(CustomField21).Append("\n");
            sb.Append("  customField22: ").Append(CustomField22).Append("\n");
            sb.Append("  customField23: ").Append(CustomField23).Append("\n");
            sb.Append("  customField24: ").Append(CustomField24).Append("\n");
            sb.Append("  customField25: ").Append(CustomField25).Append("\n");
            sb.Append("  customField26: ").Append(CustomField26).Append("\n");
            sb.Append("  customField27: ").Append(CustomField27).Append("\n");
            sb.Append("  customField28: ").Append(CustomField28).Append("\n");
            sb.Append("  customField29: ").Append(CustomField29).Append("\n");
            sb.Append("  customField30: ").Append(CustomField30).Append("\n");
            sb.Append("  customField31: ").Append(CustomField31).Append("\n");
            sb.Append("  customField32: ").Append(CustomField32).Append("\n");
            sb.Append("  customField33: ").Append(CustomField33).Append("\n");
            sb.Append("  customField34: ").Append(CustomField34).Append("\n");
            sb.Append("  customField35: ").Append(CustomField35).Append("\n");
            sb.Append("  customField36: ").Append(CustomField36).Append("\n");
            sb.Append("  customField37: ").Append(CustomField37).Append("\n");
            sb.Append("  customField38: ").Append(CustomField38).Append("\n");
            sb.Append("  customField39: ").Append(CustomField39).Append("\n");
            sb.Append("  customField40: ").Append(CustomField40).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricRequest3Dividend);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricRequest3Dividend input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OnTime == input.OnTime ||
                    (this.OnTime != null &&
                    this.OnTime.Equals(input.OnTime))
                ) && 
                (
                    this.CustomField16 == input.CustomField16 ||
                    (this.CustomField16 != null &&
                    this.CustomField16.Equals(input.CustomField16))
                ) && 
                (
                    this.CustomField17 == input.CustomField17 ||
                    (this.CustomField17 != null &&
                    this.CustomField17.Equals(input.CustomField17))
                ) && 
                (
                    this.CustomField18 == input.CustomField18 ||
                    (this.CustomField18 != null &&
                    this.CustomField18.Equals(input.CustomField18))
                ) && 
                (
                    this.CustomField19 == input.CustomField19 ||
                    (this.CustomField19 != null &&
                    this.CustomField19.Equals(input.CustomField19))
                ) && 
                (
                    this.CustomField20 == input.CustomField20 ||
                    (this.CustomField20 != null &&
                    this.CustomField20.Equals(input.CustomField20))
                ) && 
                (
                    this.CustomField21 == input.CustomField21 ||
                    (this.CustomField21 != null &&
                    this.CustomField21.Equals(input.CustomField21))
                ) && 
                (
                    this.CustomField22 == input.CustomField22 ||
                    (this.CustomField22 != null &&
                    this.CustomField22.Equals(input.CustomField22))
                ) && 
                (
                    this.CustomField23 == input.CustomField23 ||
                    (this.CustomField23 != null &&
                    this.CustomField23.Equals(input.CustomField23))
                ) && 
                (
                    this.CustomField24 == input.CustomField24 ||
                    (this.CustomField24 != null &&
                    this.CustomField24.Equals(input.CustomField24))
                ) && 
                (
                    this.CustomField25 == input.CustomField25 ||
                    (this.CustomField25 != null &&
                    this.CustomField25.Equals(input.CustomField25))
                ) && 
                (
                    this.CustomField26 == input.CustomField26 ||
                    (this.CustomField26 != null &&
                    this.CustomField26.Equals(input.CustomField26))
                ) && 
                (
                    this.CustomField27 == input.CustomField27 ||
                    (this.CustomField27 != null &&
                    this.CustomField27.Equals(input.CustomField27))
                ) && 
                (
                    this.CustomField28 == input.CustomField28 ||
                    (this.CustomField28 != null &&
                    this.CustomField28.Equals(input.CustomField28))
                ) && 
                (
                    this.CustomField29 == input.CustomField29 ||
                    (this.CustomField29 != null &&
                    this.CustomField29.Equals(input.CustomField29))
                ) && 
                (
                    this.CustomField30 == input.CustomField30 ||
                    (this.CustomField30 != null &&
                    this.CustomField30.Equals(input.CustomField30))
                ) && 
                (
                    this.CustomField31 == input.CustomField31 ||
                    (this.CustomField31 != null &&
                    this.CustomField31.Equals(input.CustomField31))
                ) && 
                (
                    this.CustomField32 == input.CustomField32 ||
                    (this.CustomField32 != null &&
                    this.CustomField32.Equals(input.CustomField32))
                ) && 
                (
                    this.CustomField33 == input.CustomField33 ||
                    (this.CustomField33 != null &&
                    this.CustomField33.Equals(input.CustomField33))
                ) && 
                (
                    this.CustomField34 == input.CustomField34 ||
                    (this.CustomField34 != null &&
                    this.CustomField34.Equals(input.CustomField34))
                ) && 
                (
                    this.CustomField35 == input.CustomField35 ||
                    (this.CustomField35 != null &&
                    this.CustomField35.Equals(input.CustomField35))
                ) && 
                (
                    this.CustomField36 == input.CustomField36 ||
                    (this.CustomField36 != null &&
                    this.CustomField36.Equals(input.CustomField36))
                ) && 
                (
                    this.CustomField37 == input.CustomField37 ||
                    (this.CustomField37 != null &&
                    this.CustomField37.Equals(input.CustomField37))
                ) && 
                (
                    this.CustomField38 == input.CustomField38 ||
                    (this.CustomField38 != null &&
                    this.CustomField38.Equals(input.CustomField38))
                ) && 
                (
                    this.CustomField39 == input.CustomField39 ||
                    (this.CustomField39 != null &&
                    this.CustomField39.Equals(input.CustomField39))
                ) && 
                (
                    this.CustomField40 == input.CustomField40 ||
                    (this.CustomField40 != null &&
                    this.CustomField40.Equals(input.CustomField40))
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
                if (this.OnTime != null)
                    hashCode = hashCode * 59 + this.OnTime.GetHashCode();
                if (this.CustomField16 != null)
                    hashCode = hashCode * 59 + this.CustomField16.GetHashCode();
                if (this.CustomField17 != null)
                    hashCode = hashCode * 59 + this.CustomField17.GetHashCode();
                if (this.CustomField18 != null)
                    hashCode = hashCode * 59 + this.CustomField18.GetHashCode();
                if (this.CustomField19 != null)
                    hashCode = hashCode * 59 + this.CustomField19.GetHashCode();
                if (this.CustomField20 != null)
                    hashCode = hashCode * 59 + this.CustomField20.GetHashCode();
                if (this.CustomField21 != null)
                    hashCode = hashCode * 59 + this.CustomField21.GetHashCode();
                if (this.CustomField22 != null)
                    hashCode = hashCode * 59 + this.CustomField22.GetHashCode();
                if (this.CustomField23 != null)
                    hashCode = hashCode * 59 + this.CustomField23.GetHashCode();
                if (this.CustomField24 != null)
                    hashCode = hashCode * 59 + this.CustomField24.GetHashCode();
                if (this.CustomField25 != null)
                    hashCode = hashCode * 59 + this.CustomField25.GetHashCode();
                if (this.CustomField26 != null)
                    hashCode = hashCode * 59 + this.CustomField26.GetHashCode();
                if (this.CustomField27 != null)
                    hashCode = hashCode * 59 + this.CustomField27.GetHashCode();
                if (this.CustomField28 != null)
                    hashCode = hashCode * 59 + this.CustomField28.GetHashCode();
                if (this.CustomField29 != null)
                    hashCode = hashCode * 59 + this.CustomField29.GetHashCode();
                if (this.CustomField30 != null)
                    hashCode = hashCode * 59 + this.CustomField30.GetHashCode();
                if (this.CustomField31 != null)
                    hashCode = hashCode * 59 + this.CustomField31.GetHashCode();
                if (this.CustomField32 != null)
                    hashCode = hashCode * 59 + this.CustomField32.GetHashCode();
                if (this.CustomField33 != null)
                    hashCode = hashCode * 59 + this.CustomField33.GetHashCode();
                if (this.CustomField34 != null)
                    hashCode = hashCode * 59 + this.CustomField34.GetHashCode();
                if (this.CustomField35 != null)
                    hashCode = hashCode * 59 + this.CustomField35.GetHashCode();
                if (this.CustomField36 != null)
                    hashCode = hashCode * 59 + this.CustomField36.GetHashCode();
                if (this.CustomField37 != null)
                    hashCode = hashCode * 59 + this.CustomField37.GetHashCode();
                if (this.CustomField38 != null)
                    hashCode = hashCode * 59 + this.CustomField38.GetHashCode();
                if (this.CustomField39 != null)
                    hashCode = hashCode * 59 + this.CustomField39.GetHashCode();
                if (this.CustomField40 != null)
                    hashCode = hashCode * 59 + this.CustomField40.GetHashCode();
                return hashCode;
            }
        }
    }
}
