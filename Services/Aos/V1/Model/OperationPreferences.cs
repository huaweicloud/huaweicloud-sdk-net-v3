using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 资源栈集操作（stack_set_operation）的部署策略。该参数只在指定的单次操作中生效。  当用户不指定该参数时，默认的操作部署策略为区域（region）内资源栈实例串行部署，即每次只执行一个资源栈实例，区域（region）间随机且串行部署，执行完一个region下的全部资源栈实例后，才会选择另一个region部署，容错次数默认为0。  该参数可以在生成资源栈集操作的四个API中指定：  创建资源栈实例（CreateStackInstance），部署资源栈集（DeployStackSet），更新资源栈实例（UpdateStackInstance），删除资源栈实例（DeleteStackInstance）
    /// </summary>
    public class OperationPreferences 
    {
        /// <summary>
        /// 部署资源栈实例时区域（region）的执行策略，分为两种，SEQUENTIAL和PARALLEL，区分大小写，默认值为SEQUENTIAL  详细介绍：  * &#x60;SEQUENTIAL&#x60;：顺序执行，执行完一个region下的全部资源栈实例后再去执行另一个region。默认顺序执行。  * &#x60;PARALLEL&#x60;：并发执行，并发部署所有指定区域的资源栈实例。
        /// </summary>
        /// <value>部署资源栈实例时区域（region）的执行策略，分为两种，SEQUENTIAL和PARALLEL，区分大小写，默认值为SEQUENTIAL  详细介绍：  * &#x60;SEQUENTIAL&#x60;：顺序执行，执行完一个region下的全部资源栈实例后再去执行另一个region。默认顺序执行。  * &#x60;PARALLEL&#x60;：并发执行，并发部署所有指定区域的资源栈实例。</value>
        [JsonConverter(typeof(EnumClassConverter<RegionConcurrencyTypeEnum>))]
        public class RegionConcurrencyTypeEnum
        {
            /// <summary>
            /// Enum SEQUENTIAL for value: SEQUENTIAL
            /// </summary>
            public static readonly RegionConcurrencyTypeEnum SEQUENTIAL = new RegionConcurrencyTypeEnum("SEQUENTIAL");

            /// <summary>
            /// Enum PARALLEL for value: PARALLEL
            /// </summary>
            public static readonly RegionConcurrencyTypeEnum PARALLEL = new RegionConcurrencyTypeEnum("PARALLEL");

            private static readonly Dictionary<string, RegionConcurrencyTypeEnum> StaticFields =
            new Dictionary<string, RegionConcurrencyTypeEnum>()
            {
                { "SEQUENTIAL", SEQUENTIAL },
                { "PARALLEL", PARALLEL },
            };

            private string _value;

            public RegionConcurrencyTypeEnum()
            {

            }

            public RegionConcurrencyTypeEnum(string value)
            {
                _value = value;
            }

            public static RegionConcurrencyTypeEnum FromValue(string value)
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

                if (this.Equals(obj as RegionConcurrencyTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RegionConcurrencyTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RegionConcurrencyTypeEnum a, RegionConcurrencyTypeEnum b)
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

            public static bool operator !=(RegionConcurrencyTypeEnum a, RegionConcurrencyTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 资源栈集操作部署的失败容忍模式，分为两种，STRICT_FAILURE_TOLERANCE和SOFT_FAILURE_TOLERANCE，区分大小写，默认值为STRICT_FAILURE_TOLERANCE。  详细介绍：  * &#x60;STRICT_FAILURE_TOLERANCE&#x60;：此选项会动态降低并发级别，以确保同region下部署失败的账户数量永远不超过 failure_tolerance_count + 1。当用户指定failure_tolerance_percentage时，确保同region下部署失败的账户数量不超过 failure_tolerance_percentage * 资源栈实例数 + 1。  * 初始实际最大并发数为max_concurrent_count，如果用户指定的是max_concurrent_percentage，则初始实际最大并发数为 max_concurrent_percentage * 资源栈实例数，随后，实际最大并发数会根据失败次数增加而减少。  * &#x60;SOFT_FAILURE_TOLERANCE&#x60;：此选项将failure_tolerance_count与实际并发数分离开。该参数允许资源栈集操作始终以指定的 max_concurrent_count 或 max_concurrent_percentage 操作资源栈实例。  * 此时不保证资源栈实例失败总数小于 failure_tolerance_count + 1，如果用户指定的是failure_tolerance_percentage的值，则部署失败次数不会超过 failure_tolerance_percentage * 资源栈实例数 + 1。
        /// </summary>
        /// <value>资源栈集操作部署的失败容忍模式，分为两种，STRICT_FAILURE_TOLERANCE和SOFT_FAILURE_TOLERANCE，区分大小写，默认值为STRICT_FAILURE_TOLERANCE。  详细介绍：  * &#x60;STRICT_FAILURE_TOLERANCE&#x60;：此选项会动态降低并发级别，以确保同region下部署失败的账户数量永远不超过 failure_tolerance_count + 1。当用户指定failure_tolerance_percentage时，确保同region下部署失败的账户数量不超过 failure_tolerance_percentage * 资源栈实例数 + 1。  * 初始实际最大并发数为max_concurrent_count，如果用户指定的是max_concurrent_percentage，则初始实际最大并发数为 max_concurrent_percentage * 资源栈实例数，随后，实际最大并发数会根据失败次数增加而减少。  * &#x60;SOFT_FAILURE_TOLERANCE&#x60;：此选项将failure_tolerance_count与实际并发数分离开。该参数允许资源栈集操作始终以指定的 max_concurrent_count 或 max_concurrent_percentage 操作资源栈实例。  * 此时不保证资源栈实例失败总数小于 failure_tolerance_count + 1，如果用户指定的是failure_tolerance_percentage的值，则部署失败次数不会超过 failure_tolerance_percentage * 资源栈实例数 + 1。</value>
        [JsonConverter(typeof(EnumClassConverter<FailureToleranceModeEnum>))]
        public class FailureToleranceModeEnum
        {
            /// <summary>
            /// Enum STRICT_FAILURE_TOLERANCE for value: STRICT_FAILURE_TOLERANCE
            /// </summary>
            public static readonly FailureToleranceModeEnum STRICT_FAILURE_TOLERANCE = new FailureToleranceModeEnum("STRICT_FAILURE_TOLERANCE");

            /// <summary>
            /// Enum SOFT_FAILURE_TOLERANCE for value: SOFT_FAILURE_TOLERANCE
            /// </summary>
            public static readonly FailureToleranceModeEnum SOFT_FAILURE_TOLERANCE = new FailureToleranceModeEnum("SOFT_FAILURE_TOLERANCE");

            private static readonly Dictionary<string, FailureToleranceModeEnum> StaticFields =
            new Dictionary<string, FailureToleranceModeEnum>()
            {
                { "STRICT_FAILURE_TOLERANCE", STRICT_FAILURE_TOLERANCE },
                { "SOFT_FAILURE_TOLERANCE", SOFT_FAILURE_TOLERANCE },
            };

            private string _value;

            public FailureToleranceModeEnum()
            {

            }

            public FailureToleranceModeEnum(string value)
            {
                _value = value;
            }

            public static FailureToleranceModeEnum FromValue(string value)
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

                if (this.Equals(obj as FailureToleranceModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FailureToleranceModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FailureToleranceModeEnum a, FailureToleranceModeEnum b)
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

            public static bool operator !=(FailureToleranceModeEnum a, FailureToleranceModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 部署资源栈实例时区域（region）的执行策略，分为两种，SEQUENTIAL和PARALLEL，区分大小写，默认值为SEQUENTIAL  详细介绍：  * &#x60;SEQUENTIAL&#x60;：顺序执行，执行完一个region下的全部资源栈实例后再去执行另一个region。默认顺序执行。  * &#x60;PARALLEL&#x60;：并发执行，并发部署所有指定区域的资源栈实例。
        /// </summary>
        [JsonProperty("region_concurrency_type", NullValueHandling = NullValueHandling.Ignore)]
        public RegionConcurrencyTypeEnum RegionConcurrencyType { get; set; }
        /// <summary>
        /// 区域（region）部署顺序。只有当用户指定region_concurrency_type为SEQUENTIAL时才会允许指定该参数。用户指定部署region的顺序，不允许出现资源栈集管理之外的region。  若不指定，实际部署region顺序随机。部署顺序仅在当次部署时生效，应该包含且仅包含本次部署的所有region。
        /// </summary>
        [JsonProperty("region_order", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RegionOrder { get; set; }

        /// <summary>
        /// 容错次数。用户定义在每个区域（region）下，允许部署失败的资源栈实例数量。该参数取值默认为0，限定0和正整数。  如果定义region顺序执行（region_concurrency_type值为SEQUENTIAL），在某个region超过容错次数时，资源栈集会取消所有状态仍处于WAIT_IN_PROGRESS状态的实例。被取消的实例状态最终变为CANCEL_COMPLETE；  如果是region并行执行（region_concurrency_type值为PARALLEL），在某个region超过容错次数时，资源栈集只会取消该region下所有处于WAIT_IN_PROGRESS状态的实例。被取消的实例状态最终变为CANCEL_COMPLETE。  对处于OPERATION_IN_PROGRESS，或已经部署完成，即处于OPERATION_COMPLETE或者OPERATION_FAILED状态的资源栈实例，不受影响，状态不变。  failure_tolerance_count  和 failure_tolerance_percentage 仅能有一个存在。
        /// </summary>
        [JsonProperty("failure_tolerance_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? FailureToleranceCount { get; set; }

        /// <summary>
        /// 容错百分比。定义每个区域（region）下，允许部署失败的资源栈实例数占该region下所有资源栈实例数的百分比。该参数取值默认为0，限定0和正整数。  通过容错百分比*资源栈实例数，并向下取整，得到实际容错次数。  当concurrency_mode指定为STRICT_FAILURE_TOLERANCE时，实际最大并发账户数最多比实际容错次数多1。  failure_tolerance_count  和 failure_tolerance_percentage 仅能有一个存在。
        /// </summary>
        [JsonProperty("failure_tolerance_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public long? FailureTolerancePercentage { get; set; }

        /// <summary>
        /// 每个区域（region）下可同时部署资源栈实例的最大账户数。该参数取值默认为1，限定为正整数。  最大并发账户数最多比容错次数多1。如果用户指定failure_tolerance_percentage，最大并发账户数最多比 failure_tolerance_percentage * 资源栈实例数多1。保证部署在所需的容错级别停止。  max_concurrent_count 和 max_concurrent_percentage 仅能有一个存在。
        /// </summary>
        [JsonProperty("max_concurrent_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxConcurrentCount { get; set; }

        /// <summary>
        /// 最大并发账户百分比，每个区域（region）中可同时部署的资源栈实例的最大账户百分比。该参数取值默认为1，限定正整数。  RFS根据百分比 *（每个region下资源栈实例数）得到的值，再向下取整，得到实际最大并发账户数。若实际最大并发账户数向下取整值为0时，则默认选择最大并发账户数为1。  通过百分比计算得到的实际最大并发账户数最多比容错次数多1。如果用户指定failure_tolerance_percentage，实际最大并发账户数最多比 failure_tolerance_percentage * 资源栈实例数多1。保证部署在所需的容错级别停止。  max_concurrent_count 和 max_concurrent_percentage 仅能有一个存在。
        /// </summary>
        [JsonProperty("max_concurrent_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxConcurrentPercentage { get; set; }

        /// <summary>
        /// 资源栈集操作部署的失败容忍模式，分为两种，STRICT_FAILURE_TOLERANCE和SOFT_FAILURE_TOLERANCE，区分大小写，默认值为STRICT_FAILURE_TOLERANCE。  详细介绍：  * &#x60;STRICT_FAILURE_TOLERANCE&#x60;：此选项会动态降低并发级别，以确保同region下部署失败的账户数量永远不超过 failure_tolerance_count + 1。当用户指定failure_tolerance_percentage时，确保同region下部署失败的账户数量不超过 failure_tolerance_percentage * 资源栈实例数 + 1。  * 初始实际最大并发数为max_concurrent_count，如果用户指定的是max_concurrent_percentage，则初始实际最大并发数为 max_concurrent_percentage * 资源栈实例数，随后，实际最大并发数会根据失败次数增加而减少。  * &#x60;SOFT_FAILURE_TOLERANCE&#x60;：此选项将failure_tolerance_count与实际并发数分离开。该参数允许资源栈集操作始终以指定的 max_concurrent_count 或 max_concurrent_percentage 操作资源栈实例。  * 此时不保证资源栈实例失败总数小于 failure_tolerance_count + 1，如果用户指定的是failure_tolerance_percentage的值，则部署失败次数不会超过 failure_tolerance_percentage * 资源栈实例数 + 1。
        /// </summary>
        [JsonProperty("failure_tolerance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public FailureToleranceModeEnum FailureToleranceMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationPreferences {\n");
            sb.Append("  regionConcurrencyType: ").Append(RegionConcurrencyType).Append("\n");
            sb.Append("  regionOrder: ").Append(RegionOrder).Append("\n");
            sb.Append("  failureToleranceCount: ").Append(FailureToleranceCount).Append("\n");
            sb.Append("  failureTolerancePercentage: ").Append(FailureTolerancePercentage).Append("\n");
            sb.Append("  maxConcurrentCount: ").Append(MaxConcurrentCount).Append("\n");
            sb.Append("  maxConcurrentPercentage: ").Append(MaxConcurrentPercentage).Append("\n");
            sb.Append("  failureToleranceMode: ").Append(FailureToleranceMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperationPreferences);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperationPreferences input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RegionConcurrencyType == input.RegionConcurrencyType ||
                    (this.RegionConcurrencyType != null &&
                    this.RegionConcurrencyType.Equals(input.RegionConcurrencyType))
                ) && 
                (
                    this.RegionOrder == input.RegionOrder ||
                    this.RegionOrder != null &&
                    input.RegionOrder != null &&
                    this.RegionOrder.SequenceEqual(input.RegionOrder)
                ) && 
                (
                    this.FailureToleranceCount == input.FailureToleranceCount ||
                    (this.FailureToleranceCount != null &&
                    this.FailureToleranceCount.Equals(input.FailureToleranceCount))
                ) && 
                (
                    this.FailureTolerancePercentage == input.FailureTolerancePercentage ||
                    (this.FailureTolerancePercentage != null &&
                    this.FailureTolerancePercentage.Equals(input.FailureTolerancePercentage))
                ) && 
                (
                    this.MaxConcurrentCount == input.MaxConcurrentCount ||
                    (this.MaxConcurrentCount != null &&
                    this.MaxConcurrentCount.Equals(input.MaxConcurrentCount))
                ) && 
                (
                    this.MaxConcurrentPercentage == input.MaxConcurrentPercentage ||
                    (this.MaxConcurrentPercentage != null &&
                    this.MaxConcurrentPercentage.Equals(input.MaxConcurrentPercentage))
                ) && 
                (
                    this.FailureToleranceMode == input.FailureToleranceMode ||
                    (this.FailureToleranceMode != null &&
                    this.FailureToleranceMode.Equals(input.FailureToleranceMode))
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
                if (this.RegionConcurrencyType != null)
                    hashCode = hashCode * 59 + this.RegionConcurrencyType.GetHashCode();
                if (this.RegionOrder != null)
                    hashCode = hashCode * 59 + this.RegionOrder.GetHashCode();
                if (this.FailureToleranceCount != null)
                    hashCode = hashCode * 59 + this.FailureToleranceCount.GetHashCode();
                if (this.FailureTolerancePercentage != null)
                    hashCode = hashCode * 59 + this.FailureTolerancePercentage.GetHashCode();
                if (this.MaxConcurrentCount != null)
                    hashCode = hashCode * 59 + this.MaxConcurrentCount.GetHashCode();
                if (this.MaxConcurrentPercentage != null)
                    hashCode = hashCode * 59 + this.MaxConcurrentPercentage.GetHashCode();
                if (this.FailureToleranceMode != null)
                    hashCode = hashCode * 59 + this.FailureToleranceMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
