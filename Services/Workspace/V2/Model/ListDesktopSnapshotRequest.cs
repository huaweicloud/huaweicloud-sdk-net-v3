using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListDesktopSnapshotRequest 
    {
        /// <summary>
        /// 快照类型。 - SYSTEM_DISK 系统盘。 - DATA_DISKS 数据盘。 - ALL 系统盘和数据盘。
        /// </summary>
        /// <value>快照类型。 - SYSTEM_DISK 系统盘。 - DATA_DISKS 数据盘。 - ALL 系统盘和数据盘。</value>
        [JsonConverter(typeof(EnumClassConverter<DiskTypeEnum>))]
        public class DiskTypeEnum
        {
            /// <summary>
            /// Enum SYSTEM_DISK for value: SYSTEM_DISK
            /// </summary>
            public static readonly DiskTypeEnum SYSTEM_DISK = new DiskTypeEnum("SYSTEM_DISK");

            /// <summary>
            /// Enum DATA_DISKS for value: DATA_DISKS
            /// </summary>
            public static readonly DiskTypeEnum DATA_DISKS = new DiskTypeEnum("DATA_DISKS");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly DiskTypeEnum ALL = new DiskTypeEnum("ALL");

            private static readonly Dictionary<string, DiskTypeEnum> StaticFields =
            new Dictionary<string, DiskTypeEnum>()
            {
                { "SYSTEM_DISK", SYSTEM_DISK },
                { "DATA_DISKS", DATA_DISKS },
                { "ALL", ALL },
            };

            private string _value;

            public DiskTypeEnum()
            {

            }

            public DiskTypeEnum(string value)
            {
                _value = value;
            }

            public static DiskTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DiskTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DiskTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DiskTypeEnum a, DiskTypeEnum b)
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

            public static bool operator !=(DiskTypeEnum a, DiskTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 快照创建类型。 - AUTO 定时任务自动创建。 - MANUALLY 手动创建。
        /// </summary>
        /// <value>快照创建类型。 - AUTO 定时任务自动创建。 - MANUALLY 手动创建。</value>
        [JsonConverter(typeof(EnumClassConverter<CreateTypeEnum>))]
        public class CreateTypeEnum
        {
            /// <summary>
            /// Enum AUTO for value: AUTO
            /// </summary>
            public static readonly CreateTypeEnum AUTO = new CreateTypeEnum("AUTO");

            /// <summary>
            /// Enum MANUALLY for value: MANUALLY
            /// </summary>
            public static readonly CreateTypeEnum MANUALLY = new CreateTypeEnum("MANUALLY");

            private static readonly Dictionary<string, CreateTypeEnum> StaticFields =
            new Dictionary<string, CreateTypeEnum>()
            {
                { "AUTO", AUTO },
                { "MANUALLY", MANUALLY },
            };

            private string _value;

            public CreateTypeEnum()
            {

            }

            public CreateTypeEnum(string value)
            {
                _value = value;
            }

            public static CreateTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CreateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CreateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CreateTypeEnum a, CreateTypeEnum b)
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

            public static bool operator !=(CreateTypeEnum a, CreateTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序字段名称，需要结合sort_type字段一起使用。 - create_time 创建时间。 - snapshot_name 快照名称。
        /// </summary>
        /// <value>排序字段名称，需要结合sort_type字段一起使用。 - create_time 创建时间。 - snapshot_name 快照名称。</value>
        [JsonConverter(typeof(EnumClassConverter<SortFieldEnum>))]
        public class SortFieldEnum
        {
            /// <summary>
            /// Enum CREATE_TIME for value: create_time
            /// </summary>
            public static readonly SortFieldEnum CREATE_TIME = new SortFieldEnum("create_time");

            /// <summary>
            /// Enum SNAPSHOT_NAME for value: snapshot_name
            /// </summary>
            public static readonly SortFieldEnum SNAPSHOT_NAME = new SortFieldEnum("snapshot_name");

            private static readonly Dictionary<string, SortFieldEnum> StaticFields =
            new Dictionary<string, SortFieldEnum>()
            {
                { "create_time", CREATE_TIME },
                { "snapshot_name", SNAPSHOT_NAME },
            };

            private string _value;

            public SortFieldEnum()
            {

            }

            public SortFieldEnum(string value)
            {
                _value = value;
            }

            public static SortFieldEnum FromValue(string value)
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

                if (this.Equals(obj as SortFieldEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortFieldEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortFieldEnum a, SortFieldEnum b)
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

            public static bool operator !=(SortFieldEnum a, SortFieldEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。
        /// </summary>
        /// <value>排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。</value>
        [JsonConverter(typeof(EnumClassConverter<SortTypeEnum>))]
        public class SortTypeEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            public static readonly SortTypeEnum ASC = new SortTypeEnum("ASC");

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            public static readonly SortTypeEnum DESC = new SortTypeEnum("DESC");

            private static readonly Dictionary<string, SortTypeEnum> StaticFields =
            new Dictionary<string, SortTypeEnum>()
            {
                { "ASC", ASC },
                { "DESC", DESC },
            };

            private string _value;

            public SortTypeEnum()
            {

            }

            public SortTypeEnum(string value)
            {
                _value = value;
            }

            public static SortTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SortTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortTypeEnum a, SortTypeEnum b)
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

            public static bool operator !=(SortTypeEnum a, SortTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 桌面id。
        /// </summary>
        [SDKProperty("desktop_id", IsQuery = true)]
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 桌面名称。
        /// </summary>
        [SDKProperty("desktop_name", IsQuery = true)]
        [JsonProperty("desktop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopName { get; set; }

        /// <summary>
        /// 快照名称。
        /// </summary>
        [SDKProperty("snapshot_name", IsQuery = true)]
        [JsonProperty("snapshot_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// 快照类型。 - SYSTEM_DISK 系统盘。 - DATA_DISKS 数据盘。 - ALL 系统盘和数据盘。
        /// </summary>
        [SDKProperty("disk_type", IsQuery = true)]
        [JsonProperty("disk_type", NullValueHandling = NullValueHandling.Ignore)]
        public DiskTypeEnum DiskType { get; set; }
        /// <summary>
        /// 快照创建类型。 - AUTO 定时任务自动创建。 - MANUALLY 手动创建。
        /// </summary>
        [SDKProperty("create_type", IsQuery = true)]
        [JsonProperty("create_type", NullValueHandling = NullValueHandling.Ignore)]
        public CreateTypeEnum CreateType { get; set; }
        /// <summary>
        /// 快照状态。 - creating：表示创建中。 - restoring：表示恢复中。 - create_success：表示创建成功。 - create_failed：表示创建快照失败。 - restore_success：表示快照恢复成功。 - restore_failed：表示快照恢复失败。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 排序字段名称，需要结合sort_type字段一起使用。 - create_time 创建时间。 - snapshot_name 快照名称。
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public SortFieldEnum SortField { get; set; }
        /// <summary>
        /// 排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。
        /// </summary>
        [SDKProperty("sort_type", IsQuery = true)]
        [JsonProperty("sort_type", NullValueHandling = NullValueHandling.Ignore)]
        public SortTypeEnum SortType { get; set; }
        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 用于分页查询。默认1000,取值范围1-1000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopSnapshotRequest {\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  desktopName: ").Append(DesktopName).Append("\n");
            sb.Append("  snapshotName: ").Append(SnapshotName).Append("\n");
            sb.Append("  diskType: ").Append(DiskType).Append("\n");
            sb.Append("  createType: ").Append(CreateType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopSnapshotRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopSnapshotRequest input)
        {
            if (input == null) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.DesktopName != input.DesktopName || (this.DesktopName != null && !this.DesktopName.Equals(input.DesktopName))) return false;
            if (this.SnapshotName != input.SnapshotName || (this.SnapshotName != null && !this.SnapshotName.Equals(input.SnapshotName))) return false;
            if (this.DiskType != input.DiskType) return false;
            if (this.CreateType != input.CreateType) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.SortField != input.SortField) return false;
            if (this.SortType != input.SortType) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.DesktopName != null) hashCode = hashCode * 59 + this.DesktopName.GetHashCode();
                if (this.SnapshotName != null) hashCode = hashCode * 59 + this.SnapshotName.GetHashCode();
                hashCode = hashCode * 59 + this.DiskType.GetHashCode();
                hashCode = hashCode * 59 + this.CreateType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.SortField.GetHashCode();
                hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
