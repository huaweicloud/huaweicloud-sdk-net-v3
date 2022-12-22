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
    public class ListDependenciesRequest 
    {

        /// <summary>
        /// 上一次查询依赖包的最后记录位置，默认为\&quot;0\&quot;。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 单次查询最大条数
        /// </summary>
        [SDKProperty("maxitems", IsQuery = true)]
        [JsonProperty("maxitems", NullValueHandling = NullValueHandling.Ignore)]
        public string Maxitems { get; set; }

        /// <summary>
        /// 是否为公共依赖包
        /// </summary>
        [SDKProperty("ispublic", IsQuery = true)]
        [JsonProperty("ispublic", NullValueHandling = NullValueHandling.Ignore)]
        public string Ispublic { get; set; }

        /// <summary>
        /// 依赖包类型public：公开,private:私有，all：全部。缺省时查询全量
        /// </summary>
        [SDKProperty("dependency_type", IsQuery = true)]
        [JsonProperty("dependency_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DependencyType { get; set; }

        /// <summary>
        /// FunctionGraph函数的执行环境 Python2.7: Python语言2.7版本。 Python3.6: Pyton语言3.6版本。 Python3.9: Python语言3.9版本。 Go1.8: Go语言1.8版本。 Go1.x: Go语言1.x版本。 Java8: Java语言8版本。 Java11: Java语言11版本。 Node.js6.10: Nodejs语言6.10版本。 Node.js8.10: Nodejs语言8.10版本。 Node.js10.16: Nodejs语言10.16版本。 Node.js12.13: Nodejs语言12.13版本。 Node.js14.18: Nodejs语言14.18版本。 C#(.NET Core 2.0): C#语言2.0版本。 C#(.NET Core 2.1): C#语言2.1版本。 C#(.NET Core 3.1): C#语言3.1版本。 Custom: 自定义运行时。 PHP7.3: Php语言7.3版本。 http: HTTP函数。
        /// </summary>
        [SDKProperty("runtime", IsQuery = true)]
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public string Runtime { get; set; }

        /// <summary>
        /// 依赖包名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 本次查询可获取的依赖包的最大数目，默认为\&quot;400\&quot;。
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
            sb.Append("class ListDependenciesRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  maxitems: ").Append(Maxitems).Append("\n");
            sb.Append("  ispublic: ").Append(Ispublic).Append("\n");
            sb.Append("  dependencyType: ").Append(DependencyType).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDependenciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDependenciesRequest input)
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
                    this.DependencyType == input.DependencyType ||
                    (this.DependencyType != null &&
                    this.DependencyType.Equals(input.DependencyType))
                ) && 
                (
                    this.Runtime == input.Runtime ||
                    (this.Runtime != null &&
                    this.Runtime.Equals(input.Runtime))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Maxitems != null)
                    hashCode = hashCode * 59 + this.Maxitems.GetHashCode();
                if (this.Ispublic != null)
                    hashCode = hashCode * 59 + this.Ispublic.GetHashCode();
                if (this.DependencyType != null)
                    hashCode = hashCode * 59 + this.DependencyType.GetHashCode();
                if (this.Runtime != null)
                    hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
