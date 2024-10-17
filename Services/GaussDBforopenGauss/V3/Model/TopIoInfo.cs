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
    /// Top IO信息
    /// </summary>
    public class TopIoInfo 
    {
        /// <summary>
        /// 线程分类标识，取值：业务（worker）和后台（background）。需将GUC参数\&quot;enable_thread_pool\&quot;设置为on
        /// </summary>
        /// <value>线程分类标识，取值：业务（worker）和后台（background）。需将GUC参数\&quot;enable_thread_pool\&quot;设置为on</value>
        [JsonConverter(typeof(EnumClassConverter<ThreadTypeEnum>))]
        public class ThreadTypeEnum
        {
            /// <summary>
            /// Enum WORKER for value: worker
            /// </summary>
            public static readonly ThreadTypeEnum WORKER = new ThreadTypeEnum("worker");

            /// <summary>
            /// Enum BACKGROUND for value: background
            /// </summary>
            public static readonly ThreadTypeEnum BACKGROUND = new ThreadTypeEnum("background");

            private static readonly Dictionary<string, ThreadTypeEnum> StaticFields =
            new Dictionary<string, ThreadTypeEnum>()
            {
                { "worker", WORKER },
                { "background", BACKGROUND },
            };

            private string _value;

            public ThreadTypeEnum()
            {

            }

            public ThreadTypeEnum(string value)
            {
                _value = value;
            }

            public static ThreadTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ThreadTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ThreadTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ThreadTypeEnum a, ThreadTypeEnum b)
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

            public static bool operator !=(ThreadTypeEnum a, ThreadTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 线程ID
        /// </summary>
        [JsonProperty("thread_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreadId { get; set; }

        /// <summary>
        /// 线程分类标识，取值：业务（worker）和后台（background）。需将GUC参数\&quot;enable_thread_pool\&quot;设置为on
        /// </summary>
        [JsonProperty("thread_type", NullValueHandling = NullValueHandling.Ignore)]
        public ThreadTypeEnum ThreadType { get; set; }
        /// <summary>
        /// 从磁盘读取数据速率, 单位：KB/s
        /// </summary>
        [JsonProperty("disk_read_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiskReadRate { get; set; }

        /// <summary>
        /// 写入磁盘数据速率, 单位：KB/s
        /// </summary>
        [JsonProperty("disk_write_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiskWriteRate { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonProperty("session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        /// <summary>
        /// SQL ID
        /// </summary>
        [JsonProperty("unique_sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueSqlId { get; set; }

        /// <summary>
        /// 数据库
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 客户端IP
        /// </summary>
        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 语句开始时间
        /// </summary>
        [JsonProperty("sql_start", NullValueHandling = NullValueHandling.Ignore)]
        public long? SqlStart { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopIoInfo {\n");
            sb.Append("  threadId: ").Append(ThreadId).Append("\n");
            sb.Append("  threadType: ").Append(ThreadType).Append("\n");
            sb.Append("  diskReadRate: ").Append(DiskReadRate).Append("\n");
            sb.Append("  diskWriteRate: ").Append(DiskWriteRate).Append("\n");
            sb.Append("  sessionId: ").Append(SessionId).Append("\n");
            sb.Append("  uniqueSqlId: ").Append(UniqueSqlId).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  clientIp: ").Append(ClientIp).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  sqlStart: ").Append(SqlStart).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopIoInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopIoInfo input)
        {
            if (input == null) return false;
            if (this.ThreadId != input.ThreadId || (this.ThreadId != null && !this.ThreadId.Equals(input.ThreadId))) return false;
            if (this.ThreadType != input.ThreadType) return false;
            if (this.DiskReadRate != input.DiskReadRate || (this.DiskReadRate != null && !this.DiskReadRate.Equals(input.DiskReadRate))) return false;
            if (this.DiskWriteRate != input.DiskWriteRate || (this.DiskWriteRate != null && !this.DiskWriteRate.Equals(input.DiskWriteRate))) return false;
            if (this.SessionId != input.SessionId || (this.SessionId != null && !this.SessionId.Equals(input.SessionId))) return false;
            if (this.UniqueSqlId != input.UniqueSqlId || (this.UniqueSqlId != null && !this.UniqueSqlId.Equals(input.UniqueSqlId))) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.ClientIp != input.ClientIp || (this.ClientIp != null && !this.ClientIp.Equals(input.ClientIp))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.SqlStart != input.SqlStart || (this.SqlStart != null && !this.SqlStart.Equals(input.SqlStart))) return false;

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
                if (this.ThreadId != null) hashCode = hashCode * 59 + this.ThreadId.GetHashCode();
                hashCode = hashCode * 59 + this.ThreadType.GetHashCode();
                if (this.DiskReadRate != null) hashCode = hashCode * 59 + this.DiskReadRate.GetHashCode();
                if (this.DiskWriteRate != null) hashCode = hashCode * 59 + this.DiskWriteRate.GetHashCode();
                if (this.SessionId != null) hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.UniqueSqlId != null) hashCode = hashCode * 59 + this.UniqueSqlId.GetHashCode();
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.ClientIp != null) hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SqlStart != null) hashCode = hashCode * 59 + this.SqlStart.GetHashCode();
                return hashCode;
            }
        }
    }
}
