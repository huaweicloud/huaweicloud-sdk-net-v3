using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 查询可用的AZ请求
    /// </summary>
    public class QueryAvailableNodeTypeReq 
    {
        /// <summary>
        /// 迁移场景 migration实时迁移，sync实时同步，dataGuard实时灾备，subscription实时订阅，replay流量回放
        /// </summary>
        /// <value>迁移场景 migration实时迁移，sync实时同步，dataGuard实时灾备，subscription实时订阅，replay流量回放</value>
        [JsonConverter(typeof(EnumClassConverter<DbUseTypeEnum>))]
        public class DbUseTypeEnum
        {
            /// <summary>
            /// Enum MIGRATION for value: migration
            /// </summary>
            public static readonly DbUseTypeEnum MIGRATION = new DbUseTypeEnum("migration");

            /// <summary>
            /// Enum SYNC for value: sync
            /// </summary>
            public static readonly DbUseTypeEnum SYNC = new DbUseTypeEnum("sync");

            /// <summary>
            /// Enum CLOUDDATAGUARD for value: cloudDataGuard
            /// </summary>
            public static readonly DbUseTypeEnum CLOUDDATAGUARD = new DbUseTypeEnum("cloudDataGuard");

            private static readonly Dictionary<string, DbUseTypeEnum> StaticFields =
            new Dictionary<string, DbUseTypeEnum>()
            {
                { "migration", MIGRATION },
                { "sync", SYNC },
                { "cloudDataGuard", CLOUDDATAGUARD },
            };

            private string _value;

            public DbUseTypeEnum()
            {

            }

            public DbUseTypeEnum(string value)
            {
                _value = value;
            }

            public static DbUseTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DbUseTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DbUseTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DbUseTypeEnum a, DbUseTypeEnum b)
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

            public static bool operator !=(DbUseTypeEnum a, DbUseTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 迁移方向，up ：入云 ，灾备场景时对应本云为备，down：出云，灾备场景时对应本云为主，non-dbs：自建
        /// </summary>
        /// <value>迁移方向，up ：入云 ，灾备场景时对应本云为备，down：出云，灾备场景时对应本云为主，non-dbs：自建</value>
        [JsonConverter(typeof(EnumClassConverter<JobDirectionEnum>))]
        public class JobDirectionEnum
        {
            /// <summary>
            /// Enum UP for value: up
            /// </summary>
            public static readonly JobDirectionEnum UP = new JobDirectionEnum("up");

            /// <summary>
            /// Enum DOWN for value: down
            /// </summary>
            public static readonly JobDirectionEnum DOWN = new JobDirectionEnum("down");

            /// <summary>
            /// Enum NON_DBS for value: non-dbs
            /// </summary>
            public static readonly JobDirectionEnum NON_DBS = new JobDirectionEnum("non-dbs");

            private static readonly Dictionary<string, JobDirectionEnum> StaticFields =
            new Dictionary<string, JobDirectionEnum>()
            {
                { "up", UP },
                { "down", DOWN },
                { "non-dbs", NON_DBS },
            };

            private string _value;

            public JobDirectionEnum()
            {

            }

            public JobDirectionEnum(string value)
            {
                _value = value;
            }

            public static JobDirectionEnum FromValue(string value)
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

                if (this.Equals(obj as JobDirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobDirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobDirectionEnum a, JobDirectionEnum b)
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

            public static bool operator !=(JobDirectionEnum a, JobDirectionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 引擎类型
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineType { get; set; }

        /// <summary>
        /// 迁移场景 migration实时迁移，sync实时同步，dataGuard实时灾备，subscription实时订阅，replay流量回放
        /// </summary>
        [JsonProperty("db_use_type", NullValueHandling = NullValueHandling.Ignore)]
        public DbUseTypeEnum DbUseType { get; set; }
        /// <summary>
        /// 迁移方向，up ：入云 ，灾备场景时对应本云为备，down：出云，灾备场景时对应本云为主，non-dbs：自建
        /// </summary>
        [JsonProperty("job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public JobDirectionEnum JobDirection { get; set; }
        /// <summary>
        /// 规格类型。 micro：极小，small：小，medium：中，high：高，xlarge：超高，2xlarge：极高
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeType { get; set; }

        /// <summary>
        /// 是否是双主灾备，不填默认为false
        /// </summary>
        [JsonProperty("multi_write", NullValueHandling = NullValueHandling.Ignore)]
        public string MultiWrite { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryAvailableNodeTypeReq {\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  dbUseType: ").Append(DbUseType).Append("\n");
            sb.Append("  jobDirection: ").Append(JobDirection).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  multiWrite: ").Append(MultiWrite).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryAvailableNodeTypeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryAvailableNodeTypeReq input)
        {
            if (input == null) return false;
            if (this.EngineType != input.EngineType || (this.EngineType != null && !this.EngineType.Equals(input.EngineType))) return false;
            if (this.DbUseType != input.DbUseType) return false;
            if (this.JobDirection != input.JobDirection) return false;
            if (this.NodeType != input.NodeType || (this.NodeType != null && !this.NodeType.Equals(input.NodeType))) return false;
            if (this.MultiWrite != input.MultiWrite || (this.MultiWrite != null && !this.MultiWrite.Equals(input.MultiWrite))) return false;

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
                if (this.EngineType != null) hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                hashCode = hashCode * 59 + this.DbUseType.GetHashCode();
                hashCode = hashCode * 59 + this.JobDirection.GetHashCode();
                if (this.NodeType != null) hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                if (this.MultiWrite != null) hashCode = hashCode * 59 + this.MultiWrite.GetHashCode();
                return hashCode;
            }
        }
    }
}
