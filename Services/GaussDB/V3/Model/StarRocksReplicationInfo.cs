using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// StarRocks同步任务信息。
    /// </summary>
    public class StarRocksReplicationInfo 
    {
        /// <summary>
        /// 当前状态。Yes:正常;No:异常。
        /// </summary>
        /// <value>当前状态。Yes:正常;No:异常。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum YES for value: Yes
            /// </summary>
            public static readonly StatusEnum YES = new StatusEnum("Yes");

            /// <summary>
            /// Enum NO for value: No
            /// </summary>
            public static readonly StatusEnum NO = new StatusEnum("No");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "Yes", YES },
                { "No", NO },
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
        /// 同步阶段。wait:等待同步;incremental:增量同步;full:全量同步;cancelled:删除;paused:暂停同步。
        /// </summary>
        /// <value>同步阶段。wait:等待同步;incremental:增量同步;full:全量同步;cancelled:删除;paused:暂停同步。</value>
        [JsonConverter(typeof(EnumClassConverter<StageEnum>))]
        public class StageEnum
        {
            /// <summary>
            /// Enum WAIT for value: wait
            /// </summary>
            public static readonly StageEnum WAIT = new StageEnum("wait");

            /// <summary>
            /// Enum INCREMENTAL for value: incremental
            /// </summary>
            public static readonly StageEnum INCREMENTAL = new StageEnum("incremental");

            /// <summary>
            /// Enum FULL for value: full
            /// </summary>
            public static readonly StageEnum FULL = new StageEnum("full");

            /// <summary>
            /// Enum CANCELLED for value: cancelled
            /// </summary>
            public static readonly StageEnum CANCELLED = new StageEnum("cancelled");

            /// <summary>
            /// Enum PAUSED for value: paused
            /// </summary>
            public static readonly StageEnum PAUSED = new StageEnum("paused");

            private static readonly Dictionary<string, StageEnum> StaticFields =
            new Dictionary<string, StageEnum>()
            {
                { "wait", WAIT },
                { "incremental", INCREMENTAL },
                { "full", FULL },
                { "cancelled", CANCELLED },
                { "paused", PAUSED },
            };

            private string _value;

            public StageEnum()
            {

            }

            public StageEnum(string value)
            {
                _value = value;
            }

            public static StageEnum FromValue(string value)
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

                if (this.Equals(obj as StageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StageEnum a, StageEnum b)
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

            public static bool operator !=(StageEnum a, StageEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 追赶阶段。wait:等待同步;incremental:增量同步;full:全量同步;cancelled:删除;paused:暂停同步。
        /// </summary>
        /// <value>追赶阶段。wait:等待同步;incremental:增量同步;full:全量同步;cancelled:删除;paused:暂停同步。</value>
        [JsonConverter(typeof(EnumClassConverter<CatchupStageEnum>))]
        public class CatchupStageEnum
        {
            /// <summary>
            /// Enum WAIT for value: wait
            /// </summary>
            public static readonly CatchupStageEnum WAIT = new CatchupStageEnum("wait");

            /// <summary>
            /// Enum INCREMENTAL for value: incremental
            /// </summary>
            public static readonly CatchupStageEnum INCREMENTAL = new CatchupStageEnum("incremental");

            /// <summary>
            /// Enum FULL for value: full
            /// </summary>
            public static readonly CatchupStageEnum FULL = new CatchupStageEnum("full");

            /// <summary>
            /// Enum CANCELLED for value: cancelled
            /// </summary>
            public static readonly CatchupStageEnum CANCELLED = new CatchupStageEnum("cancelled");

            /// <summary>
            /// Enum PAUSED for value: paused
            /// </summary>
            public static readonly CatchupStageEnum PAUSED = new CatchupStageEnum("paused");

            private static readonly Dictionary<string, CatchupStageEnum> StaticFields =
            new Dictionary<string, CatchupStageEnum>()
            {
                { "wait", WAIT },
                { "incremental", INCREMENTAL },
                { "full", FULL },
                { "cancelled", CANCELLED },
                { "paused", PAUSED },
            };

            private string _value;

            public CatchupStageEnum()
            {

            }

            public CatchupStageEnum(string value)
            {
                _value = value;
            }

            public static CatchupStageEnum FromValue(string value)
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

                if (this.Equals(obj as CatchupStageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CatchupStageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CatchupStageEnum a, CatchupStageEnum b)
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

            public static bool operator !=(CatchupStageEnum a, CatchupStageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// GaussDB(for MySQL)数据库。
        /// </summary>
        [JsonProperty("source_database", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDatabase { get; set; }

        /// <summary>
        /// 目标数据库。
        /// </summary>
        [JsonProperty("target_database", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDatabase { get; set; }

        /// <summary>
        /// 同步任务名。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 当前状态。Yes:正常;No:异常。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 同步阶段。wait:等待同步;incremental:增量同步;full:全量同步;cancelled:删除;paused:暂停同步。
        /// </summary>
        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public StageEnum Stage { get; set; }
        /// <summary>
        /// 进度百分比。
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string Percentage { get; set; }

        /// <summary>
        /// 追赶阶段。wait:等待同步;incremental:增量同步;full:全量同步;cancelled:删除;paused:暂停同步。
        /// </summary>
        [JsonProperty("catchup_stage", NullValueHandling = NullValueHandling.Ignore)]
        public CatchupStageEnum CatchupStage { get; set; }
        /// <summary>
        /// 追赶进度百分比。
        /// </summary>
        [JsonProperty("catchup_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string CatchupPercentage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StarRocksReplicationInfo {\n");
            sb.Append("  sourceDatabase: ").Append(SourceDatabase).Append("\n");
            sb.Append("  targetDatabase: ").Append(TargetDatabase).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  stage: ").Append(Stage).Append("\n");
            sb.Append("  percentage: ").Append(Percentage).Append("\n");
            sb.Append("  catchupStage: ").Append(CatchupStage).Append("\n");
            sb.Append("  catchupPercentage: ").Append(CatchupPercentage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StarRocksReplicationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StarRocksReplicationInfo input)
        {
            if (input == null) return false;
            if (this.SourceDatabase != input.SourceDatabase || (this.SourceDatabase != null && !this.SourceDatabase.Equals(input.SourceDatabase))) return false;
            if (this.TargetDatabase != input.TargetDatabase || (this.TargetDatabase != null && !this.TargetDatabase.Equals(input.TargetDatabase))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.Status != input.Status) return false;
            if (this.Stage != input.Stage) return false;
            if (this.Percentage != input.Percentage || (this.Percentage != null && !this.Percentage.Equals(input.Percentage))) return false;
            if (this.CatchupStage != input.CatchupStage) return false;
            if (this.CatchupPercentage != input.CatchupPercentage || (this.CatchupPercentage != null && !this.CatchupPercentage.Equals(input.CatchupPercentage))) return false;

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
                if (this.SourceDatabase != null) hashCode = hashCode * 59 + this.SourceDatabase.GetHashCode();
                if (this.TargetDatabase != null) hashCode = hashCode * 59 + this.TargetDatabase.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Percentage != null) hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                hashCode = hashCode * 59 + this.CatchupStage.GetHashCode();
                if (this.CatchupPercentage != null) hashCode = hashCode * 59 + this.CatchupPercentage.GetHashCode();
                return hashCode;
            }
        }
    }
}
