using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CaseAwInstance 
    {

        /// <summary>
        /// 测试用例前置步骤
        /// </summary>
        [JsonProperty("setup_aw_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwInstance> SetupAwList { get; set; }

        /// <summary>
        /// 测试步骤
        /// </summary>
        [JsonProperty("teardown_aw_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwInstance> TeardownAwList { get; set; }

        /// <summary>
        /// 测试用例后置不走
        /// </summary>
        [JsonProperty("test_aw_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwInstance> TestAwList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseAwInstance {\n");
            sb.Append("  setupAwList: ").Append(SetupAwList).Append("\n");
            sb.Append("  teardownAwList: ").Append(TeardownAwList).Append("\n");
            sb.Append("  testAwList: ").Append(TestAwList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CaseAwInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CaseAwInstance input)
        {
            if (input == null) return false;
            if (this.SetupAwList != input.SetupAwList || (this.SetupAwList != null && input.SetupAwList != null && !this.SetupAwList.SequenceEqual(input.SetupAwList))) return false;
            if (this.TeardownAwList != input.TeardownAwList || (this.TeardownAwList != null && input.TeardownAwList != null && !this.TeardownAwList.SequenceEqual(input.TeardownAwList))) return false;
            if (this.TestAwList != input.TestAwList || (this.TestAwList != null && input.TestAwList != null && !this.TestAwList.SequenceEqual(input.TestAwList))) return false;

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
                if (this.SetupAwList != null) hashCode = hashCode * 59 + this.SetupAwList.GetHashCode();
                if (this.TeardownAwList != null) hashCode = hashCode * 59 + this.TeardownAwList.GetHashCode();
                if (this.TestAwList != null) hashCode = hashCode * 59 + this.TestAwList.GetHashCode();
                return hashCode;
            }
        }
    }
}
