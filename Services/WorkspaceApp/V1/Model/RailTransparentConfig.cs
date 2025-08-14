using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 应用镜像策略设置项。
    /// </summary>
    public class RailTransparentConfig 
    {

        /// <summary>
        /// 策略选值原则。
        /// </summary>
        [JsonProperty("select_policy", NullValueHandling = NullValueHandling.Ignore)]
        public int? SelectPolicy { get; set; }

        /// <summary>
        /// 配置项内容。
        /// </summary>
        [JsonProperty("transparent_list_custom", NullValueHandling = NullValueHandling.Ignore)]
        public string TransparentListCustom { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RailTransparentConfig {\n");
            sb.Append("  selectPolicy: ").Append(SelectPolicy).Append("\n");
            sb.Append("  transparentListCustom: ").Append(TransparentListCustom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RailTransparentConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RailTransparentConfig input)
        {
            if (input == null) return false;
            if (this.SelectPolicy != input.SelectPolicy || (this.SelectPolicy != null && !this.SelectPolicy.Equals(input.SelectPolicy))) return false;
            if (this.TransparentListCustom != input.TransparentListCustom || (this.TransparentListCustom != null && !this.TransparentListCustom.Equals(input.TransparentListCustom))) return false;

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
                if (this.SelectPolicy != null) hashCode = hashCode * 59 + this.SelectPolicy.GetHashCode();
                if (this.TransparentListCustom != null) hashCode = hashCode * 59 + this.TransparentListCustom.GetHashCode();
                return hashCode;
            }
        }
    }
}
