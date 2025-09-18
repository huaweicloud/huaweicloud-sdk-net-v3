using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 容灾实例切换的RPO和RTO指标
    /// </summary>
    public class NoSQLDrRpoAndRto 
    {
        /// <summary>
        /// 场景，枚举值   FAILOVER 强制切换;    SWITCHOVER 主备倒换
        /// </summary>
        /// <value>场景，枚举值   FAILOVER 强制切换;    SWITCHOVER 主备倒换</value>
        [JsonConverter(typeof(EnumClassConverter<SceneEnum>))]
        public class SceneEnum
        {
            /// <summary>
            /// Enum FAILOVER for value: FAILOVER
            /// </summary>
            public static readonly SceneEnum FAILOVER = new SceneEnum("FAILOVER");

            /// <summary>
            /// Enum SWITCHOVER for value: SWITCHOVER
            /// </summary>
            public static readonly SceneEnum SWITCHOVER = new SceneEnum("SWITCHOVER");

            private static readonly Dictionary<string, SceneEnum> StaticFields =
            new Dictionary<string, SceneEnum>()
            {
                { "FAILOVER", FAILOVER },
                { "SWITCHOVER", SWITCHOVER },
            };

            private string _value;

            public SceneEnum()
            {

            }

            public SceneEnum(string value)
            {
                _value = value;
            }

            public static SceneEnum FromValue(string value)
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

                if (this.Equals(obj as SceneEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SceneEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SceneEnum a, SceneEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SceneEnum a, SceneEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 场景，枚举值   FAILOVER 强制切换;    SWITCHOVER 主备倒换
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public SceneEnum Scene { get; set; }
        /// <summary>
        /// 倒换或切换丢失数据时长，单位：秒（s）
        /// </summary>
        [JsonProperty("rpo", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rpo { get; set; }

        /// <summary>
        /// 倒换或切换恢复时长，单位：秒（s）
        /// </summary>
        [JsonProperty("rto", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rto { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NoSQLDrRpoAndRto {\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  rpo: ").Append(Rpo).Append("\n");
            sb.Append("  rto: ").Append(Rto).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NoSQLDrRpoAndRto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NoSQLDrRpoAndRto input)
        {
            if (input == null) return false;
            if (this.Scene != input.Scene) return false;
            if (this.Rpo != input.Rpo || (this.Rpo != null && !this.Rpo.Equals(input.Rpo))) return false;
            if (this.Rto != input.Rto || (this.Rto != null && !this.Rto.Equals(input.Rto))) return false;

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
                hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.Rpo != null) hashCode = hashCode * 59 + this.Rpo.GetHashCode();
                if (this.Rto != null) hashCode = hashCode * 59 + this.Rto.GetHashCode();
                return hashCode;
            }
        }
    }
}
