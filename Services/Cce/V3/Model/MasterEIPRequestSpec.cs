using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MasterEIPRequestSpec 
    {
        /// <summary>
        /// 绑定或解绑动作，必选参数。 - 绑定：固定值为{\&quot;action\&quot;:\&quot;bind\&quot;} - 解绑：固定值为{\&quot;action\&quot;:\&quot;unbind\&quot;} 
        /// </summary>
        /// <value>绑定或解绑动作，必选参数。 - 绑定：固定值为{\&quot;action\&quot;:\&quot;bind\&quot;} - 解绑：固定值为{\&quot;action\&quot;:\&quot;unbind\&quot;} </value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum BIND for value: bind
            /// </summary>
            public static readonly ActionEnum BIND = new ActionEnum("bind");

            /// <summary>
            /// Enum UNBIND for value: unbind
            /// </summary>
            public static readonly ActionEnum UNBIND = new ActionEnum("unbind");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "bind", BIND },
                { "unbind", UNBIND },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 绑定或解绑动作，必选参数。 - 绑定：固定值为{\&quot;action\&quot;:\&quot;bind\&quot;} - 解绑：固定值为{\&quot;action\&quot;:\&quot;unbind\&quot;} 
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public MasterEIPRequestSpecSpec Spec { get; set; }

        /// <summary>
        /// 带宽(字段已失效，暂不推荐使用)
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// 弹性网卡IP(字段已失效，暂不推荐使用)
        /// </summary>
        [JsonProperty("elasticIp", NullValueHandling = NullValueHandling.Ignore)]
        public string ElasticIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MasterEIPRequestSpec {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  elasticIp: ").Append(ElasticIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MasterEIPRequestSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MasterEIPRequestSpec input)
        {
            if (input == null) return false;
            if (this.Action != input.Action) return false;
            if (this.Spec != input.Spec || (this.Spec != null && !this.Spec.Equals(input.Spec))) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.ElasticIp != input.ElasticIp || (this.ElasticIp != null && !this.ElasticIp.Equals(input.ElasticIp))) return false;

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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Spec != null) hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.ElasticIp != null) hashCode = hashCode * 59 + this.ElasticIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
