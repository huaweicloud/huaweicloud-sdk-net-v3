using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDbObjectsListResponse : SdkResponse
    {
        /// <summary>
        /// 获取提交查询对象选择信息的状态
        /// </summary>
        /// <value>获取提交查询对象选择信息的状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("success");

            /// <summary>
            /// Enum _FAILED for value:  failed
            /// </summary>
            public static readonly StatusEnum _FAILED = new StatusEnum(" failed");

            /// <summary>
            /// Enum _PENDING for value:  pending
            /// </summary>
            public static readonly StatusEnum _PENDING = new StatusEnum(" pending");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "success", SUCCESS },
                { " failed", _FAILED },
                { " pending", _PENDING },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_root_db", NullValueHandling = NullValueHandling.Ignore)]
        public TargetRootDb TargetRootDb { get; set; }

        /// <summary>
        /// 数据库对象迁移或同步信息。
        /// </summary>
        [JsonProperty("object_info", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, DatabaseObject> ObjectInfo { get; set; }

        /// <summary>
        /// 库下表数量的阈值。
        /// </summary>
        [JsonProperty("max_table_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTableNum { get; set; }

        /// <summary>
        /// 获取提交查询对象选择信息的状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 该数据库在实时同步场景下的类型
        /// </summary>
        [JsonProperty("object_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectScope { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDbObjectsListResponse {\n");
            sb.Append("  targetRootDb: ").Append(TargetRootDb).Append("\n");
            sb.Append("  objectInfo: ").Append(ObjectInfo).Append("\n");
            sb.Append("  maxTableNum: ").Append(MaxTableNum).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  objectScope: ").Append(ObjectScope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDbObjectsListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDbObjectsListResponse input)
        {
            if (input == null) return false;
            if (this.TargetRootDb != input.TargetRootDb || (this.TargetRootDb != null && !this.TargetRootDb.Equals(input.TargetRootDb))) return false;
            if (this.ObjectInfo != input.ObjectInfo || (this.ObjectInfo != null && input.ObjectInfo != null && !this.ObjectInfo.SequenceEqual(input.ObjectInfo))) return false;
            if (this.MaxTableNum != input.MaxTableNum || (this.MaxTableNum != null && !this.MaxTableNum.Equals(input.MaxTableNum))) return false;
            if (this.Status != input.Status) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ObjectScope != input.ObjectScope || (this.ObjectScope != null && !this.ObjectScope.Equals(input.ObjectScope))) return false;

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
                if (this.TargetRootDb != null) hashCode = hashCode * 59 + this.TargetRootDb.GetHashCode();
                if (this.ObjectInfo != null) hashCode = hashCode * 59 + this.ObjectInfo.GetHashCode();
                if (this.MaxTableNum != null) hashCode = hashCode * 59 + this.MaxTableNum.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ObjectScope != null) hashCode = hashCode * 59 + this.ObjectScope.GetHashCode();
                return hashCode;
            }
        }
    }
}
