using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 实例部署形态。
    /// </summary>
    public class OpenGaussHaResponse 
    {
        /// <summary>
        /// GaussDB 分布式模式，返回值为：Enterprise（企业版）；主备版，返回值为：Ha(主备版)。
        /// </summary>
        /// <value>GaussDB 分布式模式，返回值为：Enterprise（企业版）；主备版，返回值为：Ha(主备版)。</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum ENTERPRISE for value: Enterprise
            /// </summary>
            public static readonly ModeEnum ENTERPRISE = new ModeEnum("Enterprise");

            /// <summary>
            /// Enum HA for value: Ha
            /// </summary>
            public static readonly ModeEnum HA = new ModeEnum("Ha");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "Enterprise", ENTERPRISE },
                { "Ha", HA },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 备机同步参数。  取值：  GaussDB为“sync”。 说明： - “sync”为同步模式。
        /// </summary>
        /// <value>备机同步参数。  取值：  GaussDB为“sync”。 说明： - “sync”为同步模式。</value>
        [JsonConverter(typeof(EnumClassConverter<ReplicationModeEnum>))]
        public class ReplicationModeEnum
        {
            /// <summary>
            /// Enum SYNC for value: sync
            /// </summary>
            public static readonly ReplicationModeEnum SYNC = new ReplicationModeEnum("sync");

            private static readonly Dictionary<string, ReplicationModeEnum> StaticFields =
            new Dictionary<string, ReplicationModeEnum>()
            {
                { "sync", SYNC },
            };

            private string _value;

            public ReplicationModeEnum()
            {

            }

            public ReplicationModeEnum(string value)
            {
                _value = value;
            }

            public static ReplicationModeEnum FromValue(string value)
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

                if (this.Equals(obj as ReplicationModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReplicationModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReplicationModeEnum a, ReplicationModeEnum b)
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

            public static bool operator !=(ReplicationModeEnum a, ReplicationModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// GaussDB的预留参数：指定实例一致性类型，取值范围：strong（强一致性） | eventual(最终一致性)。
        /// </summary>
        /// <value>GaussDB的预留参数：指定实例一致性类型，取值范围：strong（强一致性） | eventual(最终一致性)。</value>
        [JsonConverter(typeof(EnumClassConverter<ConsistencyEnum>))]
        public class ConsistencyEnum
        {
            /// <summary>
            /// Enum STRONG for value: strong
            /// </summary>
            public static readonly ConsistencyEnum STRONG = new ConsistencyEnum("strong");

            /// <summary>
            /// Enum EVENTUAL for value: eventual
            /// </summary>
            public static readonly ConsistencyEnum EVENTUAL = new ConsistencyEnum("eventual");

            private static readonly Dictionary<string, ConsistencyEnum> StaticFields =
            new Dictionary<string, ConsistencyEnum>()
            {
                { "strong", STRONG },
                { "eventual", EVENTUAL },
            };

            private string _value;

            public ConsistencyEnum()
            {

            }

            public ConsistencyEnum(string value)
            {
                _value = value;
            }

            public static ConsistencyEnum FromValue(string value)
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

                if (this.Equals(obj as ConsistencyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConsistencyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConsistencyEnum a, ConsistencyEnum b)
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

            public static bool operator !=(ConsistencyEnum a, ConsistencyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// GaussDB 分布式模式，返回值为：Enterprise（企业版）；主备版，返回值为：Ha(主备版)。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 备机同步参数。  取值：  GaussDB为“sync”。 说明： - “sync”为同步模式。
        /// </summary>
        [JsonProperty("replication_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ReplicationModeEnum ReplicationMode { get; set; }
        /// <summary>
        /// GaussDB的预留参数：指定实例一致性类型，取值范围：strong（强一致性） | eventual(最终一致性)。
        /// </summary>
        [JsonProperty("consistency", NullValueHandling = NullValueHandling.Ignore)]
        public ConsistencyEnum Consistency { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenGaussHaResponse {\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  replicationMode: ").Append(ReplicationMode).Append("\n");
            sb.Append("  consistency: ").Append(Consistency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenGaussHaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenGaussHaResponse input)
        {
            if (input == null) return false;
            if (this.Mode != input.Mode) return false;
            if (this.ReplicationMode != input.ReplicationMode) return false;
            if (this.Consistency != input.Consistency) return false;

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
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                hashCode = hashCode * 59 + this.ReplicationMode.GetHashCode();
                hashCode = hashCode * 59 + this.Consistency.GetHashCode();
                return hashCode;
            }
        }
    }
}
