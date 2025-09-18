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
    /// 删除在线迁移任务请求体
    /// </summary>
    public class DeleteJobReq 
    {
        /// <summary>
        /// terminate:结束迁移任务,force_terminate:强制结束迁移任务,delete:删除迁移任务
        /// </summary>
        /// <value>terminate:结束迁移任务,force_terminate:强制结束迁移任务,delete:删除迁移任务</value>
        [JsonConverter(typeof(EnumClassConverter<DeleteTypeEnum>))]
        public class DeleteTypeEnum
        {
            /// <summary>
            /// Enum TERMINATE for value: terminate
            /// </summary>
            public static readonly DeleteTypeEnum TERMINATE = new DeleteTypeEnum("terminate");

            /// <summary>
            /// Enum FORCE_TERMINATE for value: force_terminate
            /// </summary>
            public static readonly DeleteTypeEnum FORCE_TERMINATE = new DeleteTypeEnum("force_terminate");

            /// <summary>
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly DeleteTypeEnum DELETE = new DeleteTypeEnum("delete");

            private static readonly Dictionary<string, DeleteTypeEnum> StaticFields =
            new Dictionary<string, DeleteTypeEnum>()
            {
                { "terminate", TERMINATE },
                { "force_terminate", FORCE_TERMINATE },
                { "delete", DELETE },
            };

            private string _value;

            public DeleteTypeEnum()
            {

            }

            public DeleteTypeEnum(string value)
            {
                _value = value;
            }

            public static DeleteTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DeleteTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeleteTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeleteTypeEnum a, DeleteTypeEnum b)
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

            public static bool operator !=(DeleteTypeEnum a, DeleteTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// terminate:结束迁移任务,force_terminate:强制结束迁移任务,delete:删除迁移任务
        /// </summary>
        [JsonProperty("delete_type", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteTypeEnum DeleteType { get; set; }
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// MySQL为源，实时迁移，实时同步，数据订阅，实时灾备结束任务时是否展示断点信息
        /// </summary>
        [JsonProperty("is_show_breakpoint_position", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShowBreakpointPosition { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteJobReq {\n");
            sb.Append("  deleteType: ").Append(DeleteType).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  isShowBreakpointPosition: ").Append(IsShowBreakpointPosition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteJobReq input)
        {
            if (input == null) return false;
            if (this.DeleteType != input.DeleteType) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.IsShowBreakpointPosition != input.IsShowBreakpointPosition || (this.IsShowBreakpointPosition != null && !this.IsShowBreakpointPosition.Equals(input.IsShowBreakpointPosition))) return false;

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
                hashCode = hashCode * 59 + this.DeleteType.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.IsShowBreakpointPosition != null) hashCode = hashCode * 59 + this.IsShowBreakpointPosition.GetHashCode();
                return hashCode;
            }
        }
    }
}
