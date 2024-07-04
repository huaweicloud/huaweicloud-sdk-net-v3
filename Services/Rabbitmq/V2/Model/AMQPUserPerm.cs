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
    public class AMQPUserPerm 
    {

        /// <summary>
        /// 需要配置权限的Vhost名称，一个用户可以配置多个Vhost下的资源权限。
        /// </summary>
        [JsonProperty("vhost", NullValueHandling = NullValueHandling.Ignore)]
        public string Vhost { get; set; }

        /// <summary>
        /// 使用正则表达式匹配资源配置权限。例如，在输入框内输入“^janeway-.*”，则表示授权给该用户当前Vhost下，所有名称以“janeway-”开头的资源的配置权限。
        /// </summary>
        [JsonProperty("conf", NullValueHandling = NullValueHandling.Ignore)]
        public string Conf { get; set; }

        /// <summary>
        /// 使用正则表达式匹配资源写权限。例如，在输入框内输入“.*”，则表示授权给该用户当前Vhost下，所有资源的写权限。
        /// </summary>
        [JsonProperty("write", NullValueHandling = NullValueHandling.Ignore)]
        public string Write { get; set; }

        /// <summary>
        /// 使用正则表达式匹配资源读权限。例如，在输入框内输入“.*”，则表示授权给该用户当前Vhost下，所有资源的读权限。
        /// </summary>
        [JsonProperty("read", NullValueHandling = NullValueHandling.Ignore)]
        public string Read { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AMQPUserPerm {\n");
            sb.Append("  vhost: ").Append(Vhost).Append("\n");
            sb.Append("  conf: ").Append(Conf).Append("\n");
            sb.Append("  write: ").Append(Write).Append("\n");
            sb.Append("  read: ").Append(Read).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AMQPUserPerm);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AMQPUserPerm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Vhost == input.Vhost ||
                    (this.Vhost != null &&
                    this.Vhost.Equals(input.Vhost))
                ) && 
                (
                    this.Conf == input.Conf ||
                    (this.Conf != null &&
                    this.Conf.Equals(input.Conf))
                ) && 
                (
                    this.Write == input.Write ||
                    (this.Write != null &&
                    this.Write.Equals(input.Write))
                ) && 
                (
                    this.Read == input.Read ||
                    (this.Read != null &&
                    this.Read.Equals(input.Read))
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
                if (this.Vhost != null)
                    hashCode = hashCode * 59 + this.Vhost.GetHashCode();
                if (this.Conf != null)
                    hashCode = hashCode * 59 + this.Conf.GetHashCode();
                if (this.Write != null)
                    hashCode = hashCode * 59 + this.Write.GetHashCode();
                if (this.Read != null)
                    hashCode = hashCode * 59 + this.Read.GetHashCode();
                return hashCode;
            }
        }
    }
}
