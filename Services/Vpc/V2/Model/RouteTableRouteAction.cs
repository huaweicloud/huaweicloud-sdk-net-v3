using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 更新路由表路由对象动作，可选add、mod、del
    /// </summary>
    public class RouteTableRouteAction 
    {

        /// <summary>
        /// 新增路由条目，type，destination，nexthop必选
        /// </summary>
        [JsonProperty("add", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddRouteTableRoute> Add { get; set; }

        /// <summary>
        /// 修改路由条目，type，destination，nexthop必选
        /// </summary>
        [JsonProperty("mod", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModRouteTableRoute> Mod { get; set; }

        /// <summary>
        /// 删除路由条目，destination必选
        /// </summary>
        [JsonProperty("del", NullValueHandling = NullValueHandling.Ignore)]
        public List<DelRouteTableRoute> Del { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RouteTableRouteAction {\n");
            sb.Append("  add: ").Append(Add).Append("\n");
            sb.Append("  mod: ").Append(Mod).Append("\n");
            sb.Append("  del: ").Append(Del).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RouteTableRouteAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RouteTableRouteAction input)
        {
            if (input == null) return false;
            if (this.Add != input.Add || (this.Add != null && input.Add != null && !this.Add.SequenceEqual(input.Add))) return false;
            if (this.Mod != input.Mod || (this.Mod != null && input.Mod != null && !this.Mod.SequenceEqual(input.Mod))) return false;
            if (this.Del != input.Del || (this.Del != null && input.Del != null && !this.Del.SequenceEqual(input.Del))) return false;

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
                if (this.Add != null) hashCode = hashCode * 59 + this.Add.GetHashCode();
                if (this.Mod != null) hashCode = hashCode * 59 + this.Mod.GetHashCode();
                if (this.Del != null) hashCode = hashCode * 59 + this.Del.GetHashCode();
                return hashCode;
            }
        }
    }
}
