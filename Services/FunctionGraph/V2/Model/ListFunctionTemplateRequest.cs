using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListFunctionTemplateRequest 
    {

        /// <summary>
        /// 本次查询起始位置，默认值0
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 每次查询获取的最大模板数量。
        /// </summary>
        [SDKProperty("maxitems", IsQuery = true)]
        [JsonProperty("maxitems", NullValueHandling = NullValueHandling.Ignore)]
        public string Maxitems { get; set; }

        /// <summary>
        /// 是否为公开模板
        /// </summary>
        [SDKProperty("ispublic", IsQuery = true)]
        [JsonProperty("ispublic", NullValueHandling = NullValueHandling.Ignore)]
        public string Ispublic { get; set; }

        /// <summary>
        /// 指定运行时模板
        /// </summary>
        [SDKProperty("runtime", IsQuery = true)]
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public string Runtime { get; set; }

        /// <summary>
        /// 指定场景模板
        /// </summary>
        [SDKProperty("scene", IsQuery = true)]
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }

        /// <summary>
        /// 指定云服务模板
        /// </summary>
        [SDKProperty("service", IsQuery = true)]
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFunctionTemplateRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  maxitems: ").Append(Maxitems).Append("\n");
            sb.Append("  ispublic: ").Append(Ispublic).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFunctionTemplateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFunctionTemplateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Maxitems == input.Maxitems ||
                    (this.Maxitems != null &&
                    this.Maxitems.Equals(input.Maxitems))
                ) && 
                (
                    this.Ispublic == input.Ispublic ||
                    (this.Ispublic != null &&
                    this.Ispublic.Equals(input.Ispublic))
                ) && 
                (
                    this.Runtime == input.Runtime ||
                    (this.Runtime != null &&
                    this.Runtime.Equals(input.Runtime))
                ) && 
                (
                    this.Scene == input.Scene ||
                    (this.Scene != null &&
                    this.Scene.Equals(input.Scene))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
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
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Maxitems != null)
                    hashCode = hashCode * 59 + this.Maxitems.GetHashCode();
                if (this.Ispublic != null)
                    hashCode = hashCode * 59 + this.Ispublic.GetHashCode();
                if (this.Runtime != null)
                    hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Scene != null)
                    hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                return hashCode;
            }
        }
    }
}
