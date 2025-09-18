using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// HA配置参数，创建HA实例时使用。
    /// </summary>
    public class HaResponse 
    {
        /// <summary>
        /// 备机同步参数。实例主备模式为Ha时有效。 取值： - MySQL为“async”或“semisync”。 - PostgreSQL为“async”或“sync”。 - Microsoft SQL Server为“sync”。
        /// </summary>
        /// <value>备机同步参数。实例主备模式为Ha时有效。 取值： - MySQL为“async”或“semisync”。 - PostgreSQL为“async”或“sync”。 - Microsoft SQL Server为“sync”。</value>
        [JsonConverter(typeof(EnumClassConverter<ReplicationModeEnum>))]
        public class ReplicationModeEnum
        {
            /// <summary>
            /// Enum ASYNC for value: async
            /// </summary>
            public static readonly ReplicationModeEnum ASYNC = new ReplicationModeEnum("async");

            /// <summary>
            /// Enum SEMISYNC for value: semisync
            /// </summary>
            public static readonly ReplicationModeEnum SEMISYNC = new ReplicationModeEnum("semisync");

            /// <summary>
            /// Enum SYNC for value: sync
            /// </summary>
            public static readonly ReplicationModeEnum SYNC = new ReplicationModeEnum("sync");

            private static readonly Dictionary<string, ReplicationModeEnum> StaticFields =
            new Dictionary<string, ReplicationModeEnum>()
            {
                { "async", ASYNC },
                { "semisync", SEMISYNC },
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

            public static bool operator !=(ReplicationModeEnum a, ReplicationModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 备机同步参数。实例主备模式为Ha时有效。 取值： - MySQL为“async”或“semisync”。 - PostgreSQL为“async”或“sync”。 - Microsoft SQL Server为“sync”。
        /// </summary>
        [JsonProperty("replication_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ReplicationModeEnum ReplicationMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HaResponse {\n");
            sb.Append("  replicationMode: ").Append(ReplicationMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HaResponse input)
        {
            if (input == null) return false;
            if (this.ReplicationMode != input.ReplicationMode) return false;

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
                hashCode = hashCode * 59 + this.ReplicationMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
