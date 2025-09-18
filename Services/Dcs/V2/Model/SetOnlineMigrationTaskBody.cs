using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 配置在线数据迁移任务结构体
    /// </summary>
    public class SetOnlineMigrationTaskBody 
    {
        /// <summary>
        /// 迁移方式，包括全量迁移和增量迁移两种类型。 - 全量迁移：该模式为Redis的一次性迁移，适用于可中断业务的迁移场景。   全量迁移过程中，如果源Redis有数据更新，这部分更新数据不会被迁移到目标Redis。 - 增量迁移：该模式为Redis的持续性迁移，适用于对业务中断敏感的迁移场景。   增量迁移阶段通过解析日志等技术， 持续保持源Redis和目标端Redis的数据一致。 取值范围： - full_amount_migration：表示全量迁移。 - incremental_migration：表示增量迁移。 
        /// </summary>
        /// <value>迁移方式，包括全量迁移和增量迁移两种类型。 - 全量迁移：该模式为Redis的一次性迁移，适用于可中断业务的迁移场景。   全量迁移过程中，如果源Redis有数据更新，这部分更新数据不会被迁移到目标Redis。 - 增量迁移：该模式为Redis的持续性迁移，适用于对业务中断敏感的迁移场景。   增量迁移阶段通过解析日志等技术， 持续保持源Redis和目标端Redis的数据一致。 取值范围： - full_amount_migration：表示全量迁移。 - incremental_migration：表示增量迁移。 </value>
        [JsonConverter(typeof(EnumClassConverter<MigrationMethodEnum>))]
        public class MigrationMethodEnum
        {
            /// <summary>
            /// Enum FULL_AMOUNT_MIGRATION for value: full_amount_migration
            /// </summary>
            public static readonly MigrationMethodEnum FULL_AMOUNT_MIGRATION = new MigrationMethodEnum("full_amount_migration");

            /// <summary>
            /// Enum INCREMENTAL_MIGRATION for value: incremental_migration
            /// </summary>
            public static readonly MigrationMethodEnum INCREMENTAL_MIGRATION = new MigrationMethodEnum("incremental_migration");

            private static readonly Dictionary<string, MigrationMethodEnum> StaticFields =
            new Dictionary<string, MigrationMethodEnum>()
            {
                { "full_amount_migration", FULL_AMOUNT_MIGRATION },
                { "incremental_migration", INCREMENTAL_MIGRATION },
            };

            private string _value;

            public MigrationMethodEnum()
            {

            }

            public MigrationMethodEnum(string value)
            {
                _value = value;
            }

            public static MigrationMethodEnum FromValue(string value)
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

                if (this.Equals(obj as MigrationMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MigrationMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MigrationMethodEnum a, MigrationMethodEnum b)
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

            public static bool operator !=(MigrationMethodEnum a, MigrationMethodEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 自动重连，根据参数决定是否自动重连。 自动重连模式在遇到网络等异常情况时，会无限自动重试。 自动重连模式在无法进行增量同步时，会触发全量同步，增加带宽占用，请谨慎选择。 取值范围： - auto：自动重连。 - manual：手动重连。 
        /// </summary>
        /// <value>自动重连，根据参数决定是否自动重连。 自动重连模式在遇到网络等异常情况时，会无限自动重试。 自动重连模式在无法进行增量同步时，会触发全量同步，增加带宽占用，请谨慎选择。 取值范围： - auto：自动重连。 - manual：手动重连。 </value>
        [JsonConverter(typeof(EnumClassConverter<ResumeModeEnum>))]
        public class ResumeModeEnum
        {
            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly ResumeModeEnum AUTO = new ResumeModeEnum("auto");

            /// <summary>
            /// Enum MANUAL for value: manual
            /// </summary>
            public static readonly ResumeModeEnum MANUAL = new ResumeModeEnum("manual");

            private static readonly Dictionary<string, ResumeModeEnum> StaticFields =
            new Dictionary<string, ResumeModeEnum>()
            {
                { "auto", AUTO },
                { "manual", MANUAL },
            };

            private string _value;

            public ResumeModeEnum()
            {

            }

            public ResumeModeEnum(string value)
            {
                _value = value;
            }

            public static ResumeModeEnum FromValue(string value)
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

                if (this.Equals(obj as ResumeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResumeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResumeModeEnum a, ResumeModeEnum b)
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

            public static bool operator !=(ResumeModeEnum a, ResumeModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 迁移方式，包括全量迁移和增量迁移两种类型。 - 全量迁移：该模式为Redis的一次性迁移，适用于可中断业务的迁移场景。   全量迁移过程中，如果源Redis有数据更新，这部分更新数据不会被迁移到目标Redis。 - 增量迁移：该模式为Redis的持续性迁移，适用于对业务中断敏感的迁移场景。   增量迁移阶段通过解析日志等技术， 持续保持源Redis和目标端Redis的数据一致。 取值范围： - full_amount_migration：表示全量迁移。 - incremental_migration：表示增量迁移。 
        /// </summary>
        [JsonProperty("migration_method", NullValueHandling = NullValueHandling.Ignore)]
        public MigrationMethodEnum MigrationMethod { get; set; }
        /// <summary>
        /// 自动重连，根据参数决定是否自动重连。 自动重连模式在遇到网络等异常情况时，会无限自动重试。 自动重连模式在无法进行增量同步时，会触发全量同步，增加带宽占用，请谨慎选择。 取值范围： - auto：自动重连。 - manual：手动重连。 
        /// </summary>
        [JsonProperty("resume_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ResumeModeEnum ResumeMode { get; set; }
        /// <summary>
        /// 带宽限制，当迁移方式为增量迁移时，为保证业务正常运行，您可以启用带宽限制功能，当数据同步速度达到带宽限制时，将限制同步速度的继续增长。 -限制为MB/s -取值范围：1-10,241(大于0小于10,241的整数)
        /// </summary>
        [JsonProperty("bandwidth_limit_mb", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthLimitMb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_instance", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigMigrationInstanceBody SourceInstance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_instance", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigMigrationInstanceBody TargetInstance { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetOnlineMigrationTaskBody {\n");
            sb.Append("  migrationMethod: ").Append(MigrationMethod).Append("\n");
            sb.Append("  resumeMode: ").Append(ResumeMode).Append("\n");
            sb.Append("  bandwidthLimitMb: ").Append(BandwidthLimitMb).Append("\n");
            sb.Append("  sourceInstance: ").Append(SourceInstance).Append("\n");
            sb.Append("  targetInstance: ").Append(TargetInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetOnlineMigrationTaskBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetOnlineMigrationTaskBody input)
        {
            if (input == null) return false;
            if (this.MigrationMethod != input.MigrationMethod) return false;
            if (this.ResumeMode != input.ResumeMode) return false;
            if (this.BandwidthLimitMb != input.BandwidthLimitMb || (this.BandwidthLimitMb != null && !this.BandwidthLimitMb.Equals(input.BandwidthLimitMb))) return false;
            if (this.SourceInstance != input.SourceInstance || (this.SourceInstance != null && !this.SourceInstance.Equals(input.SourceInstance))) return false;
            if (this.TargetInstance != input.TargetInstance || (this.TargetInstance != null && !this.TargetInstance.Equals(input.TargetInstance))) return false;

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
                hashCode = hashCode * 59 + this.MigrationMethod.GetHashCode();
                hashCode = hashCode * 59 + this.ResumeMode.GetHashCode();
                if (this.BandwidthLimitMb != null) hashCode = hashCode * 59 + this.BandwidthLimitMb.GetHashCode();
                if (this.SourceInstance != null) hashCode = hashCode * 59 + this.SourceInstance.GetHashCode();
                if (this.TargetInstance != null) hashCode = hashCode * 59 + this.TargetInstance.GetHashCode();
                return hashCode;
            }
        }
    }
}
