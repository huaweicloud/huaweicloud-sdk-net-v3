using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExchangeDetails 
    {

        /// <summary>
        /// 是否持久化
        /// </summary>
        [JsonProperty("durable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Durable { get; set; }

        /// <summary>
        /// 是否是默认Exchange
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        /// <summary>
        /// 是否是内部Exchange
        /// </summary>
        [JsonProperty("internal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Internal { get; set; }

        /// <summary>
        /// 参数列表
        /// </summary>
        [JsonProperty("arguments", NullValueHandling = NullValueHandling.Ignore)]
        public Object Arguments { get; set; }

        /// <summary>
        /// Exchange名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否自动删除
        /// </summary>
        [JsonProperty("auto_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoDelete { get; set; }

        /// <summary>
        /// Exchange类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 所属Vhost
        /// </summary>
        [JsonProperty("vhost", NullValueHandling = NullValueHandling.Ignore)]
        public string Vhost { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeDetails {\n");
            sb.Append("  durable: ").Append(Durable).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  arguments: ").Append(Arguments).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  autoDelete: ").Append(AutoDelete).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  vhost: ").Append(Vhost).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExchangeDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExchangeDetails input)
        {
            if (input == null) return false;
            if (this.Durable != input.Durable || (this.Durable != null && !this.Durable.Equals(input.Durable))) return false;
            if (this.Default != input.Default || (this.Default != null && !this.Default.Equals(input.Default))) return false;
            if (this.Internal != input.Internal || (this.Internal != null && !this.Internal.Equals(input.Internal))) return false;
            if (this.Arguments != input.Arguments || (this.Arguments != null && !this.Arguments.Equals(input.Arguments))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AutoDelete != input.AutoDelete || (this.AutoDelete != null && !this.AutoDelete.Equals(input.AutoDelete))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Vhost != input.Vhost || (this.Vhost != null && !this.Vhost.Equals(input.Vhost))) return false;

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
                if (this.Durable != null) hashCode = hashCode * 59 + this.Durable.GetHashCode();
                if (this.Default != null) hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Internal != null) hashCode = hashCode * 59 + this.Internal.GetHashCode();
                if (this.Arguments != null) hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AutoDelete != null) hashCode = hashCode * 59 + this.AutoDelete.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Vhost != null) hashCode = hashCode * 59 + this.Vhost.GetHashCode();
                return hashCode;
            }
        }
    }
}
