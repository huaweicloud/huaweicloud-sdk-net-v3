using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowHistoryTasksRequest 
    {
        /// <summary>
        /// 任务状态。 task_inprocess 表示任务处理中，task_done表示任务完成。
        /// </summary>
        /// <value>任务状态。 task_inprocess 表示任务处理中，task_done表示任务完成。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum TASK_INPROCESS for value: task_inprocess
            /// </summary>
            public static readonly StatusEnum TASK_INPROCESS = new StatusEnum("task_inprocess");

            /// <summary>
            /// Enum TASK_DONE for value: task_done
            /// </summary>
            public static readonly StatusEnum TASK_DONE = new StatusEnum("task_done");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "task_inprocess", TASK_INPROCESS },
                { "task_done", TASK_DONE },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 默认是文件file。file：文件,directory：目录。
        /// </summary>
        /// <value>默认是文件file。file：文件,directory：目录。</value>
        [JsonConverter(typeof(EnumClassConverter<FileTypeEnum>))]
        public class FileTypeEnum
        {
            /// <summary>
            /// Enum FILE for value: file
            /// </summary>
            public static readonly FileTypeEnum FILE = new FileTypeEnum("file");

            /// <summary>
            /// Enum DIRECTORY for value: directory
            /// </summary>
            public static readonly FileTypeEnum DIRECTORY = new FileTypeEnum("directory");

            private static readonly Dictionary<string, FileTypeEnum> StaticFields =
            new Dictionary<string, FileTypeEnum>()
            {
                { "file", FILE },
                { "directory", DIRECTORY },
            };

            private string _value;

            public FileTypeEnum()
            {

            }

            public FileTypeEnum(string value)
            {
                _value = value;
            }

            public static FileTypeEnum FromValue(string value)
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

                if (this.Equals(obj as FileTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FileTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FileTypeEnum a, FileTypeEnum b)
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

            public static bool operator !=(FileTypeEnum a, FileTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 当用户开启企业项目功能时，该参数生效，表示查询资源所属项目，\&quot;all\&quot;表示所有项目。注意：当使用子帐号调用接口时，该参数必传。  您可以通过调用企业项目管理服务（EPS）的查询企业项目列表接口（ListEnterpriseProject）查询企业项目id。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 单页最大数量，取值范围为1-10000。page_size和page_number必须同时传值。默认值30。
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 当前查询第几页，取值范围为1-65535。默认值1。
        /// </summary>
        [SDKProperty("page_number", IsQuery = true)]
        [JsonProperty("page_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 任务状态。 task_inprocess 表示任务处理中，task_done表示任务完成。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 查询起始时间，相对于UTC 1970-01-01到当前时间相隔的毫秒数。
        /// </summary>
        [SDKProperty("start_date", IsQuery = true)]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartDate { get; set; }

        /// <summary>
        /// 查询结束时间，相对于UTC 1970-01-01到当前时间相隔的毫秒数。
        /// </summary>
        [SDKProperty("end_date", IsQuery = true)]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndDate { get; set; }

        /// <summary>
        /// 用来排序的字段，支持的字段有“task_type”，“total”，“processing”， “succeed”，“failed”，“create_time”。order_field和order_type必须同时传值，否则使用默认值\&quot;create_time\&quot; 和 \&quot;desc\&quot;。
        /// </summary>
        [SDKProperty("order_field", IsQuery = true)]
        [JsonProperty("order_field", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderField { get; set; }

        /// <summary>
        /// desc 或者asc。默认值desc。
        /// </summary>
        [SDKProperty("order_type", IsQuery = true)]
        [JsonProperty("order_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderType { get; set; }

        /// <summary>
        /// 默认是文件file。file：文件,directory：目录。
        /// </summary>
        [SDKProperty("file_type", IsQuery = true)]
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public FileTypeEnum FileType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHistoryTasksRequest {\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  pageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  orderField: ").Append(OrderField).Append("\n");
            sb.Append("  orderType: ").Append(OrderType).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHistoryTasksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHistoryTasksRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    (this.PageNumber != null &&
                    this.PageNumber.Equals(input.PageNumber))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.OrderField == input.OrderField ||
                    (this.OrderField != null &&
                    this.OrderField.Equals(input.OrderField))
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
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
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.PageNumber != null)
                    hashCode = hashCode * 59 + this.PageNumber.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.OrderField != null)
                    hashCode = hashCode * 59 + this.OrderField.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                return hashCode;
            }
        }
    }
}
