using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TrainingJobBasicInfo 
    {
        /// <summary>
        /// 任务的状态。  与MetaStudio Console上用户看到的状态映射关系如下：  - 待提交   * WAIT_FILE_UPLOAD: 待上传文件  - 系统审核中   * AUTO_VERIFYING: 自动审核中   * MANUAL_VERIFYING: 人工审核中  - 系统审核未通过   * AUTO_VERIFY_FAILED: 自动审核失败   * MANUAL_VERIFY_FAILED: 人工审核失败  - 算法训练中   &gt; 算法训练中的状态仅管理员需要处理，普通用户仅需要显示“算法训练中”即可。   * MANUAL_VERIFY_SUCCESS: 审核通过，等待预处理资源   * WAIT_TRAINING_DATA_PREPROCESS: 等待训练数据预处理   * TRAINING_DATA_PREPROCESSING: 训练数据预处理中   * TRAINING_DATA_PREPROCESS_FAILED: 训练数据预处理失败   * TRAINING_DATA_PREPROCESS_SUCCESS: 训练数据预处理完成，等待训练资源中   * TRAINING: 训练中   * TRAIN_FAILED: 训练失败   * TRAIN_SUCCESS: 训练完成，等待预处理资源   * INFERENCE_DATA_PREPROCESSING: 推理数据预处理中   * INFERENCE_DATA_PREPROCESS_FAILED: 推理数据预处理失败   * WAIT_MAIN_FILE_UPLOAD: 等待主文件上传   * MANUAL_STOP_INFERENCE_DATA_PREPROCESS: 人工中止推理预处理   * MANUAL_STOP_TRAIN: 人工中止训练   * MANUAL_STOP_TRAINING_DATA_PREPROCESS: 人工中止训练预处理   * WAIT_ADMIN_CONFIRM: 等待管理员审核   * WAIT_COMPILE: 等待转编译   * COMPILING: 转编译中   * COMPILE_FAILED: 转编译失败   * WAIT_GENERATE_ACTION: 等待原子动作生成   * WAIT_ARRANGE: 等待编排   * ACTION_GENERATE_DATA_PROCESSING: 原子动作生成中   * MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING: 人工中止动作生成   * MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING: 人工中止动作编排   * ACTION_GENERATE_ORI_PROCESSING: 动作编排中   * ACTION_GENERATE_DATA_FAILED: 动作生成失败   * ACTION_GENERATE_ORI_FAILED: 生成动作编排资产失败   * ACTION_GENERATE_ORI_SUCCESS: 动作编排成功   * GENERATE_ACTION_PREPROCESS_FAILED: 生成动作编排原子动作失败   * WAIT_ADMIN_CALIBRATION: 等待管理员确认动作信息   * WAIT_ASSET_SYNC: 等待资产同步   * WAIT_GENERATE_ACTION_MARK 等待动作标定   * ACTION_MARKING: 动作标定生成 - 待用户审核，仅NA白名单用户有该状态   * WAIT_USER_CONFIRM: 等待用户确认训练效果  - 用户驳回，仅NA白名单用户有该状态   * JOB_REJECT: 驳回任务  - 已完成   * JOB_SUCCESS: 训练任务完成（普通用户任务的完成状态，此时用户已经可以使用模型）   * JOB_FINISH: 任务结束，是最终状态，不支持修改此状态(NA用户任务的完成状态，并且此状态表明模型效果已通过用户的验收)  - 挂起，仅NA白名单用户有该状态   * JOB_PENDING: 挂起任务   * WAIT_TEST_VIDEO_CHECK: 等待进行测试视频推理任务  * TEST_VIDEO_CHECK_PROCESSING：测试视频推理质量检测中  * TEST_VIDEO_CHECK_SUCCESS：测试视频推理质量检测通过  * TEST_VIDEO_CHECK_FAILED：测试视频推理质量检测未通过  * VIDEO_ANALYZE_PROCESSING：视频检测中  * VIDEO_ANALYZE_SUCCESS：视频检测通过  * VIDEO_ANALYZE_FAILED：视频检测未通过  * ACTION_MARKING：动作标定中  * ACTION_MARK_SUCCESS：动作标定成功  * ACTION_MARK_FAILED：动作标定失败  * ACTION_MARK_UPLOADED：动作标定文件上传成功  * MANUL_STOP_ACTION_MARK：中止动作标定
        /// </summary>
        /// <value>任务的状态。  与MetaStudio Console上用户看到的状态映射关系如下：  - 待提交   * WAIT_FILE_UPLOAD: 待上传文件  - 系统审核中   * AUTO_VERIFYING: 自动审核中   * MANUAL_VERIFYING: 人工审核中  - 系统审核未通过   * AUTO_VERIFY_FAILED: 自动审核失败   * MANUAL_VERIFY_FAILED: 人工审核失败  - 算法训练中   &gt; 算法训练中的状态仅管理员需要处理，普通用户仅需要显示“算法训练中”即可。   * MANUAL_VERIFY_SUCCESS: 审核通过，等待预处理资源   * WAIT_TRAINING_DATA_PREPROCESS: 等待训练数据预处理   * TRAINING_DATA_PREPROCESSING: 训练数据预处理中   * TRAINING_DATA_PREPROCESS_FAILED: 训练数据预处理失败   * TRAINING_DATA_PREPROCESS_SUCCESS: 训练数据预处理完成，等待训练资源中   * TRAINING: 训练中   * TRAIN_FAILED: 训练失败   * TRAIN_SUCCESS: 训练完成，等待预处理资源   * INFERENCE_DATA_PREPROCESSING: 推理数据预处理中   * INFERENCE_DATA_PREPROCESS_FAILED: 推理数据预处理失败   * WAIT_MAIN_FILE_UPLOAD: 等待主文件上传   * MANUAL_STOP_INFERENCE_DATA_PREPROCESS: 人工中止推理预处理   * MANUAL_STOP_TRAIN: 人工中止训练   * MANUAL_STOP_TRAINING_DATA_PREPROCESS: 人工中止训练预处理   * WAIT_ADMIN_CONFIRM: 等待管理员审核   * WAIT_COMPILE: 等待转编译   * COMPILING: 转编译中   * COMPILE_FAILED: 转编译失败   * WAIT_GENERATE_ACTION: 等待原子动作生成   * WAIT_ARRANGE: 等待编排   * ACTION_GENERATE_DATA_PROCESSING: 原子动作生成中   * MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING: 人工中止动作生成   * MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING: 人工中止动作编排   * ACTION_GENERATE_ORI_PROCESSING: 动作编排中   * ACTION_GENERATE_DATA_FAILED: 动作生成失败   * ACTION_GENERATE_ORI_FAILED: 生成动作编排资产失败   * ACTION_GENERATE_ORI_SUCCESS: 动作编排成功   * GENERATE_ACTION_PREPROCESS_FAILED: 生成动作编排原子动作失败   * WAIT_ADMIN_CALIBRATION: 等待管理员确认动作信息   * WAIT_ASSET_SYNC: 等待资产同步   * WAIT_GENERATE_ACTION_MARK 等待动作标定   * ACTION_MARKING: 动作标定生成 - 待用户审核，仅NA白名单用户有该状态   * WAIT_USER_CONFIRM: 等待用户确认训练效果  - 用户驳回，仅NA白名单用户有该状态   * JOB_REJECT: 驳回任务  - 已完成   * JOB_SUCCESS: 训练任务完成（普通用户任务的完成状态，此时用户已经可以使用模型）   * JOB_FINISH: 任务结束，是最终状态，不支持修改此状态(NA用户任务的完成状态，并且此状态表明模型效果已通过用户的验收)  - 挂起，仅NA白名单用户有该状态   * JOB_PENDING: 挂起任务   * WAIT_TEST_VIDEO_CHECK: 等待进行测试视频推理任务  * TEST_VIDEO_CHECK_PROCESSING：测试视频推理质量检测中  * TEST_VIDEO_CHECK_SUCCESS：测试视频推理质量检测通过  * TEST_VIDEO_CHECK_FAILED：测试视频推理质量检测未通过  * VIDEO_ANALYZE_PROCESSING：视频检测中  * VIDEO_ANALYZE_SUCCESS：视频检测通过  * VIDEO_ANALYZE_FAILED：视频检测未通过  * ACTION_MARKING：动作标定中  * ACTION_MARK_SUCCESS：动作标定成功  * ACTION_MARK_FAILED：动作标定失败  * ACTION_MARK_UPLOADED：动作标定文件上传成功  * MANUL_STOP_ACTION_MARK：中止动作标定</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum WAIT_FILE_UPLOAD for value: WAIT_FILE_UPLOAD
            /// </summary>
            public static readonly StateEnum WAIT_FILE_UPLOAD = new StateEnum("WAIT_FILE_UPLOAD");

            /// <summary>
            /// Enum AUTO_VERIFYING for value: AUTO_VERIFYING
            /// </summary>
            public static readonly StateEnum AUTO_VERIFYING = new StateEnum("AUTO_VERIFYING");

            /// <summary>
            /// Enum AUTO_VERIFY_FAILED for value: AUTO_VERIFY_FAILED
            /// </summary>
            public static readonly StateEnum AUTO_VERIFY_FAILED = new StateEnum("AUTO_VERIFY_FAILED");

            /// <summary>
            /// Enum MANUAL_VERIFYING for value: MANUAL_VERIFYING
            /// </summary>
            public static readonly StateEnum MANUAL_VERIFYING = new StateEnum("MANUAL_VERIFYING");

            /// <summary>
            /// Enum WAIT_TRAINING_DATA_PREPROCESS for value: WAIT_TRAINING_DATA_PREPROCESS
            /// </summary>
            public static readonly StateEnum WAIT_TRAINING_DATA_PREPROCESS = new StateEnum("WAIT_TRAINING_DATA_PREPROCESS");

            /// <summary>
            /// Enum MANUAL_VERIFY_FAILED for value: MANUAL_VERIFY_FAILED
            /// </summary>
            public static readonly StateEnum MANUAL_VERIFY_FAILED = new StateEnum("MANUAL_VERIFY_FAILED");

            /// <summary>
            /// Enum MANUAL_VERIFY_SUCCESS for value: MANUAL_VERIFY_SUCCESS
            /// </summary>
            public static readonly StateEnum MANUAL_VERIFY_SUCCESS = new StateEnum("MANUAL_VERIFY_SUCCESS");

            /// <summary>
            /// Enum TRAINING_DATA_PREPROCESSING for value: TRAINING_DATA_PREPROCESSING
            /// </summary>
            public static readonly StateEnum TRAINING_DATA_PREPROCESSING = new StateEnum("TRAINING_DATA_PREPROCESSING");

            /// <summary>
            /// Enum TRAINING_DATA_PREPROCESS_FAILED for value: TRAINING_DATA_PREPROCESS_FAILED
            /// </summary>
            public static readonly StateEnum TRAINING_DATA_PREPROCESS_FAILED = new StateEnum("TRAINING_DATA_PREPROCESS_FAILED");

            /// <summary>
            /// Enum TRAINING_DATA_PREPROCESS_SUCCESS for value: TRAINING_DATA_PREPROCESS_SUCCESS
            /// </summary>
            public static readonly StateEnum TRAINING_DATA_PREPROCESS_SUCCESS = new StateEnum("TRAINING_DATA_PREPROCESS_SUCCESS");

            /// <summary>
            /// Enum TRAINING for value: TRAINING
            /// </summary>
            public static readonly StateEnum TRAINING = new StateEnum("TRAINING");

            /// <summary>
            /// Enum TRAIN_FAILED for value: TRAIN_FAILED
            /// </summary>
            public static readonly StateEnum TRAIN_FAILED = new StateEnum("TRAIN_FAILED");

            /// <summary>
            /// Enum TRAIN_SUCCESS for value: TRAIN_SUCCESS
            /// </summary>
            public static readonly StateEnum TRAIN_SUCCESS = new StateEnum("TRAIN_SUCCESS");

            /// <summary>
            /// Enum INFERENCE_DATA_PREPROCESSING for value: INFERENCE_DATA_PREPROCESSING
            /// </summary>
            public static readonly StateEnum INFERENCE_DATA_PREPROCESSING = new StateEnum("INFERENCE_DATA_PREPROCESSING");

            /// <summary>
            /// Enum INFERENCE_DATA_PREPROCESS_FAILED for value: INFERENCE_DATA_PREPROCESS_FAILED
            /// </summary>
            public static readonly StateEnum INFERENCE_DATA_PREPROCESS_FAILED = new StateEnum("INFERENCE_DATA_PREPROCESS_FAILED");

            /// <summary>
            /// Enum WAIT_MASK_UPLOAD for value: WAIT_MASK_UPLOAD
            /// </summary>
            public static readonly StateEnum WAIT_MASK_UPLOAD = new StateEnum("WAIT_MASK_UPLOAD");

            /// <summary>
            /// Enum WAIT_MAIN_FILE_UPLOAD for value: WAIT_MAIN_FILE_UPLOAD
            /// </summary>
            public static readonly StateEnum WAIT_MAIN_FILE_UPLOAD = new StateEnum("WAIT_MAIN_FILE_UPLOAD");

            /// <summary>
            /// Enum JOB_SUCCESS for value: JOB_SUCCESS
            /// </summary>
            public static readonly StateEnum JOB_SUCCESS = new StateEnum("JOB_SUCCESS");

            /// <summary>
            /// Enum MANUAL_STOP_INFERENCE_DATA_PREPROCESS for value: MANUAL_STOP_INFERENCE_DATA_PREPROCESS
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_INFERENCE_DATA_PREPROCESS = new StateEnum("MANUAL_STOP_INFERENCE_DATA_PREPROCESS");

            /// <summary>
            /// Enum MANUAL_STOP_TRAIN for value: MANUAL_STOP_TRAIN
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_TRAIN = new StateEnum("MANUAL_STOP_TRAIN");

            /// <summary>
            /// Enum MANUAL_STOP_TRAINING_DATA_PREPROCESS for value: MANUAL_STOP_TRAINING_DATA_PREPROCESS
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_TRAINING_DATA_PREPROCESS = new StateEnum("MANUAL_STOP_TRAINING_DATA_PREPROCESS");

            /// <summary>
            /// Enum MANUAL_STOP_BEAUTY_PREPROCESS for value: MANUAL_STOP_BEAUTY_PREPROCESS
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_BEAUTY_PREPROCESS = new StateEnum("MANUAL_STOP_BEAUTY_PREPROCESS");

            /// <summary>
            /// Enum WAIT_USER_CONFIRM for value: WAIT_USER_CONFIRM
            /// </summary>
            public static readonly StateEnum WAIT_USER_CONFIRM = new StateEnum("WAIT_USER_CONFIRM");

            /// <summary>
            /// Enum JOB_REJECT for value: JOB_REJECT
            /// </summary>
            public static readonly StateEnum JOB_REJECT = new StateEnum("JOB_REJECT");

            /// <summary>
            /// Enum JOB_PENDING for value: JOB_PENDING
            /// </summary>
            public static readonly StateEnum JOB_PENDING = new StateEnum("JOB_PENDING");

            /// <summary>
            /// Enum WAIT_ASSET_SYNC for value: WAIT_ASSET_SYNC
            /// </summary>
            public static readonly StateEnum WAIT_ASSET_SYNC = new StateEnum("WAIT_ASSET_SYNC");

            /// <summary>
            /// Enum WAIT_ADMIN_CONFIRM for value: WAIT_ADMIN_CONFIRM
            /// </summary>
            public static readonly StateEnum WAIT_ADMIN_CONFIRM = new StateEnum("WAIT_ADMIN_CONFIRM");

            /// <summary>
            /// Enum JOB_FINISH for value: JOB_FINISH
            /// </summary>
            public static readonly StateEnum JOB_FINISH = new StateEnum("JOB_FINISH");

            /// <summary>
            /// Enum COMPILING for value: COMPILING
            /// </summary>
            public static readonly StateEnum COMPILING = new StateEnum("COMPILING");

            /// <summary>
            /// Enum WAIT_COMPILE for value: WAIT_COMPILE
            /// </summary>
            public static readonly StateEnum WAIT_COMPILE = new StateEnum("WAIT_COMPILE");

            /// <summary>
            /// Enum COMPILE_FAILED for value: COMPILE_FAILED
            /// </summary>
            public static readonly StateEnum COMPILE_FAILED = new StateEnum("COMPILE_FAILED");

            /// <summary>
            /// Enum WAIT_BEAUTY for value: WAIT_BEAUTY
            /// </summary>
            public static readonly StateEnum WAIT_BEAUTY = new StateEnum("WAIT_BEAUTY");

            /// <summary>
            /// Enum WAIT_GENERATE_ACTION for value: WAIT_GENERATE_ACTION
            /// </summary>
            public static readonly StateEnum WAIT_GENERATE_ACTION = new StateEnum("WAIT_GENERATE_ACTION");

            /// <summary>
            /// Enum WAIT_ARRANGE for value: WAIT_ARRANGE
            /// </summary>
            public static readonly StateEnum WAIT_ARRANGE = new StateEnum("WAIT_ARRANGE");

            /// <summary>
            /// Enum ACTION_GENERATE_DATA_PROCESSING for value: ACTION_GENERATE_DATA_PROCESSING
            /// </summary>
            public static readonly StateEnum ACTION_GENERATE_DATA_PROCESSING = new StateEnum("ACTION_GENERATE_DATA_PROCESSING");

            /// <summary>
            /// Enum MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING for value: MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING = new StateEnum("MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING");

            /// <summary>
            /// Enum MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING for value: MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING
            /// </summary>
            public static readonly StateEnum MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING = new StateEnum("MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING");

            /// <summary>
            /// Enum ACTION_GENERATE_ORI_PROCESSING for value: ACTION_GENERATE_ORI_PROCESSING
            /// </summary>
            public static readonly StateEnum ACTION_GENERATE_ORI_PROCESSING = new StateEnum("ACTION_GENERATE_ORI_PROCESSING");

            /// <summary>
            /// Enum ACTION_GENERATE_DATA_FAILED for value: ACTION_GENERATE_DATA_FAILED
            /// </summary>
            public static readonly StateEnum ACTION_GENERATE_DATA_FAILED = new StateEnum("ACTION_GENERATE_DATA_FAILED");

            /// <summary>
            /// Enum ACTION_GENERATE_ORI_FAILED for value: ACTION_GENERATE_ORI_FAILED
            /// </summary>
            public static readonly StateEnum ACTION_GENERATE_ORI_FAILED = new StateEnum("ACTION_GENERATE_ORI_FAILED");

            /// <summary>
            /// Enum ACTION_GENERATE_ORI_SUCCESS for value: ACTION_GENERATE_ORI_SUCCESS
            /// </summary>
            public static readonly StateEnum ACTION_GENERATE_ORI_SUCCESS = new StateEnum("ACTION_GENERATE_ORI_SUCCESS");

            /// <summary>
            /// Enum GENERATE_ACTION_PREPROCESS_FAILED for value: GENERATE_ACTION_PREPROCESS_FAILED
            /// </summary>
            public static readonly StateEnum GENERATE_ACTION_PREPROCESS_FAILED = new StateEnum("GENERATE_ACTION_PREPROCESS_FAILED");

            /// <summary>
            /// Enum WAIT_ADMIN_CALIBRATION for value: WAIT_ADMIN_CALIBRATION
            /// </summary>
            public static readonly StateEnum WAIT_ADMIN_CALIBRATION = new StateEnum("WAIT_ADMIN_CALIBRATION");

            /// <summary>
            /// Enum BEAUTY_VIDEO_FILE_UPLOADED for value: BEAUTY_VIDEO_FILE_UPLOADED
            /// </summary>
            public static readonly StateEnum BEAUTY_VIDEO_FILE_UPLOADED = new StateEnum("BEAUTY_VIDEO_FILE_UPLOADED");

            /// <summary>
            /// Enum BEAUTYFACE_SUCCESS for value: BEAUTYFACE_SUCCESS
            /// </summary>
            public static readonly StateEnum BEAUTYFACE_SUCCESS = new StateEnum("BEAUTYFACE_SUCCESS");

            /// <summary>
            /// Enum BEAUTYFACE_FAILED for value: BEAUTYFACE_FAILED
            /// </summary>
            public static readonly StateEnum BEAUTYFACE_FAILED = new StateEnum("BEAUTYFACE_FAILED");

            /// <summary>
            /// Enum WAIT_BEAUTY_VIDEO_FILE_UPLOAD for value: WAIT_BEAUTY_VIDEO_FILE_UPLOAD
            /// </summary>
            public static readonly StateEnum WAIT_BEAUTY_VIDEO_FILE_UPLOAD = new StateEnum("WAIT_BEAUTY_VIDEO_FILE_UPLOAD");

            /// <summary>
            /// Enum BEAUTYFACE_ROCESSING for value: BEAUTYFACE_ROCESSING
            /// </summary>
            public static readonly StateEnum BEAUTYFACE_ROCESSING = new StateEnum("BEAUTYFACE_ROCESSING");

            /// <summary>
            /// Enum WAIT_TEST_VIDEO_CHECK for value: WAIT_TEST_VIDEO_CHECK
            /// </summary>
            public static readonly StateEnum WAIT_TEST_VIDEO_CHECK = new StateEnum("WAIT_TEST_VIDEO_CHECK");

            /// <summary>
            /// Enum TEST_VIDEO_CHECK_PROCESSING for value: TEST_VIDEO_CHECK_PROCESSING
            /// </summary>
            public static readonly StateEnum TEST_VIDEO_CHECK_PROCESSING = new StateEnum("TEST_VIDEO_CHECK_PROCESSING");

            /// <summary>
            /// Enum TEST_VIDEO_CHECK_SUCCESS for value: TEST_VIDEO_CHECK_SUCCESS
            /// </summary>
            public static readonly StateEnum TEST_VIDEO_CHECK_SUCCESS = new StateEnum("TEST_VIDEO_CHECK_SUCCESS");

            /// <summary>
            /// Enum TEST_VIDEO_CHECK_FAILED for value: TEST_VIDEO_CHECK_FAILED
            /// </summary>
            public static readonly StateEnum TEST_VIDEO_CHECK_FAILED = new StateEnum("TEST_VIDEO_CHECK_FAILED");

            /// <summary>
            /// Enum VIDEO_ANALYZE_PROCESSING for value: VIDEO_ANALYZE_PROCESSING
            /// </summary>
            public static readonly StateEnum VIDEO_ANALYZE_PROCESSING = new StateEnum("VIDEO_ANALYZE_PROCESSING");

            /// <summary>
            /// Enum VIDEO_ANALYZE_SUCCESS for value: VIDEO_ANALYZE_SUCCESS
            /// </summary>
            public static readonly StateEnum VIDEO_ANALYZE_SUCCESS = new StateEnum("VIDEO_ANALYZE_SUCCESS");

            /// <summary>
            /// Enum VIDEO_ANALYZE_FAILED for value: VIDEO_ANALYZE_FAILED
            /// </summary>
            public static readonly StateEnum VIDEO_ANALYZE_FAILED = new StateEnum("VIDEO_ANALYZE_FAILED");

            /// <summary>
            /// Enum ACTION_MARKING for value: ACTION_MARKING
            /// </summary>
            public static readonly StateEnum ACTION_MARKING = new StateEnum("ACTION_MARKING");

            /// <summary>
            /// Enum ACTION_MARK_SUCCESS for value: ACTION_MARK_SUCCESS
            /// </summary>
            public static readonly StateEnum ACTION_MARK_SUCCESS = new StateEnum("ACTION_MARK_SUCCESS");

            /// <summary>
            /// Enum ACTION_MARK_FAILED for value: ACTION_MARK_FAILED
            /// </summary>
            public static readonly StateEnum ACTION_MARK_FAILED = new StateEnum("ACTION_MARK_FAILED");

            /// <summary>
            /// Enum ACTION_MARK_UPLOADED for value: ACTION_MARK_UPLOADED
            /// </summary>
            public static readonly StateEnum ACTION_MARK_UPLOADED = new StateEnum("ACTION_MARK_UPLOADED");

            /// <summary>
            /// Enum WAIT_GENERATE_ACTION_MARK for value: WAIT_GENERATE_ACTION_MARK
            /// </summary>
            public static readonly StateEnum WAIT_GENERATE_ACTION_MARK = new StateEnum("WAIT_GENERATE_ACTION_MARK");

            /// <summary>
            /// Enum MANUL_STOP_ACTION_MARK for value: MANUL_STOP_ACTION_MARK
            /// </summary>
            public static readonly StateEnum MANUL_STOP_ACTION_MARK = new StateEnum("MANUL_STOP_ACTION_MARK");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "WAIT_FILE_UPLOAD", WAIT_FILE_UPLOAD },
                { "AUTO_VERIFYING", AUTO_VERIFYING },
                { "AUTO_VERIFY_FAILED", AUTO_VERIFY_FAILED },
                { "MANUAL_VERIFYING", MANUAL_VERIFYING },
                { "WAIT_TRAINING_DATA_PREPROCESS", WAIT_TRAINING_DATA_PREPROCESS },
                { "MANUAL_VERIFY_FAILED", MANUAL_VERIFY_FAILED },
                { "MANUAL_VERIFY_SUCCESS", MANUAL_VERIFY_SUCCESS },
                { "TRAINING_DATA_PREPROCESSING", TRAINING_DATA_PREPROCESSING },
                { "TRAINING_DATA_PREPROCESS_FAILED", TRAINING_DATA_PREPROCESS_FAILED },
                { "TRAINING_DATA_PREPROCESS_SUCCESS", TRAINING_DATA_PREPROCESS_SUCCESS },
                { "TRAINING", TRAINING },
                { "TRAIN_FAILED", TRAIN_FAILED },
                { "TRAIN_SUCCESS", TRAIN_SUCCESS },
                { "INFERENCE_DATA_PREPROCESSING", INFERENCE_DATA_PREPROCESSING },
                { "INFERENCE_DATA_PREPROCESS_FAILED", INFERENCE_DATA_PREPROCESS_FAILED },
                { "WAIT_MASK_UPLOAD", WAIT_MASK_UPLOAD },
                { "WAIT_MAIN_FILE_UPLOAD", WAIT_MAIN_FILE_UPLOAD },
                { "JOB_SUCCESS", JOB_SUCCESS },
                { "MANUAL_STOP_INFERENCE_DATA_PREPROCESS", MANUAL_STOP_INFERENCE_DATA_PREPROCESS },
                { "MANUAL_STOP_TRAIN", MANUAL_STOP_TRAIN },
                { "MANUAL_STOP_TRAINING_DATA_PREPROCESS", MANUAL_STOP_TRAINING_DATA_PREPROCESS },
                { "MANUAL_STOP_BEAUTY_PREPROCESS", MANUAL_STOP_BEAUTY_PREPROCESS },
                { "WAIT_USER_CONFIRM", WAIT_USER_CONFIRM },
                { "JOB_REJECT", JOB_REJECT },
                { "JOB_PENDING", JOB_PENDING },
                { "WAIT_ASSET_SYNC", WAIT_ASSET_SYNC },
                { "WAIT_ADMIN_CONFIRM", WAIT_ADMIN_CONFIRM },
                { "JOB_FINISH", JOB_FINISH },
                { "COMPILING", COMPILING },
                { "WAIT_COMPILE", WAIT_COMPILE },
                { "COMPILE_FAILED", COMPILE_FAILED },
                { "WAIT_BEAUTY", WAIT_BEAUTY },
                { "WAIT_GENERATE_ACTION", WAIT_GENERATE_ACTION },
                { "WAIT_ARRANGE", WAIT_ARRANGE },
                { "ACTION_GENERATE_DATA_PROCESSING", ACTION_GENERATE_DATA_PROCESSING },
                { "MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING", MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING },
                { "MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING", MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING },
                { "ACTION_GENERATE_ORI_PROCESSING", ACTION_GENERATE_ORI_PROCESSING },
                { "ACTION_GENERATE_DATA_FAILED", ACTION_GENERATE_DATA_FAILED },
                { "ACTION_GENERATE_ORI_FAILED", ACTION_GENERATE_ORI_FAILED },
                { "ACTION_GENERATE_ORI_SUCCESS", ACTION_GENERATE_ORI_SUCCESS },
                { "GENERATE_ACTION_PREPROCESS_FAILED", GENERATE_ACTION_PREPROCESS_FAILED },
                { "WAIT_ADMIN_CALIBRATION", WAIT_ADMIN_CALIBRATION },
                { "BEAUTY_VIDEO_FILE_UPLOADED", BEAUTY_VIDEO_FILE_UPLOADED },
                { "BEAUTYFACE_SUCCESS", BEAUTYFACE_SUCCESS },
                { "BEAUTYFACE_FAILED", BEAUTYFACE_FAILED },
                { "WAIT_BEAUTY_VIDEO_FILE_UPLOAD", WAIT_BEAUTY_VIDEO_FILE_UPLOAD },
                { "BEAUTYFACE_ROCESSING", BEAUTYFACE_ROCESSING },
                { "WAIT_TEST_VIDEO_CHECK", WAIT_TEST_VIDEO_CHECK },
                { "TEST_VIDEO_CHECK_PROCESSING", TEST_VIDEO_CHECK_PROCESSING },
                { "TEST_VIDEO_CHECK_SUCCESS", TEST_VIDEO_CHECK_SUCCESS },
                { "TEST_VIDEO_CHECK_FAILED", TEST_VIDEO_CHECK_FAILED },
                { "VIDEO_ANALYZE_PROCESSING", VIDEO_ANALYZE_PROCESSING },
                { "VIDEO_ANALYZE_SUCCESS", VIDEO_ANALYZE_SUCCESS },
                { "VIDEO_ANALYZE_FAILED", VIDEO_ANALYZE_FAILED },
                { "ACTION_MARKING", ACTION_MARKING },
                { "ACTION_MARK_SUCCESS", ACTION_MARK_SUCCESS },
                { "ACTION_MARK_FAILED", ACTION_MARK_FAILED },
                { "ACTION_MARK_UPLOADED", ACTION_MARK_UPLOADED },
                { "WAIT_GENERATE_ACTION_MARK", WAIT_GENERATE_ACTION_MARK },
                { "MANUL_STOP_ACTION_MARK", MANUL_STOP_ACTION_MARK },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 分身数字人模型版本。默认是V3.2版本模型。 * V3.2：V3.2版本模型 * V3.3: 极速版flexus用的训练模型 &gt; * V3和V2版本已废弃不用
        /// </summary>
        /// <value>分身数字人模型版本。默认是V3.2版本模型。 * V3.2：V3.2版本模型 * V3.3: 极速版flexus用的训练模型 &gt; * V3和V2版本已废弃不用</value>
        [JsonConverter(typeof(EnumClassConverter<ModelVersionEnum>))]
        public class ModelVersionEnum
        {
            /// <summary>
            /// Enum V2 for value: V2
            /// </summary>
            public static readonly ModelVersionEnum V2 = new ModelVersionEnum("V2");

            /// <summary>
            /// Enum V3 for value: V3
            /// </summary>
            public static readonly ModelVersionEnum V3 = new ModelVersionEnum("V3");

            /// <summary>
            /// Enum V3_2 for value: V3.2
            /// </summary>
            public static readonly ModelVersionEnum V3_2 = new ModelVersionEnum("V3.2");

            /// <summary>
            /// Enum V3_3 for value: V3.3
            /// </summary>
            public static readonly ModelVersionEnum V3_3 = new ModelVersionEnum("V3.3");

            private static readonly Dictionary<string, ModelVersionEnum> StaticFields =
            new Dictionary<string, ModelVersionEnum>()
            {
                { "V2", V2 },
                { "V3", V3 },
                { "V3.2", V3_2 },
                { "V3.3", V3_3 },
            };

            private string _value;

            public ModelVersionEnum()
            {

            }

            public ModelVersionEnum(string value)
            {
                _value = value;
            }

            public static ModelVersionEnum FromValue(string value)
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

                if (this.Equals(obj as ModelVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModelVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModelVersionEnum a, ModelVersionEnum b)
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

            public static bool operator !=(ModelVersionEnum a, ModelVersionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 抠图类型。默认是AI。 * AI：AI抠图 * MANUAL：人工抠图
        /// </summary>
        /// <value>抠图类型。默认是AI。 * AI：AI抠图 * MANUAL：人工抠图</value>
        [JsonConverter(typeof(EnumClassConverter<MattingTypeEnum>))]
        public class MattingTypeEnum
        {
            /// <summary>
            /// Enum AI for value: AI
            /// </summary>
            public static readonly MattingTypeEnum AI = new MattingTypeEnum("AI");

            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            public static readonly MattingTypeEnum MANUAL = new MattingTypeEnum("MANUAL");

            private static readonly Dictionary<string, MattingTypeEnum> StaticFields =
            new Dictionary<string, MattingTypeEnum>()
            {
                { "AI", AI },
                { "MANUAL", MANUAL },
            };

            private string _value;

            public MattingTypeEnum()
            {

            }

            public MattingTypeEnum(string value)
            {
                _value = value;
            }

            public static MattingTypeEnum FromValue(string value)
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

                if (this.Equals(obj as MattingTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MattingTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MattingTypeEnum a, MattingTypeEnum b)
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

            public static bool operator !=(MattingTypeEnum a, MattingTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 分身数字人模型名称。该名称会作为资产库中分身数字人模型资产名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 任务的状态。  与MetaStudio Console上用户看到的状态映射关系如下：  - 待提交   * WAIT_FILE_UPLOAD: 待上传文件  - 系统审核中   * AUTO_VERIFYING: 自动审核中   * MANUAL_VERIFYING: 人工审核中  - 系统审核未通过   * AUTO_VERIFY_FAILED: 自动审核失败   * MANUAL_VERIFY_FAILED: 人工审核失败  - 算法训练中   &gt; 算法训练中的状态仅管理员需要处理，普通用户仅需要显示“算法训练中”即可。   * MANUAL_VERIFY_SUCCESS: 审核通过，等待预处理资源   * WAIT_TRAINING_DATA_PREPROCESS: 等待训练数据预处理   * TRAINING_DATA_PREPROCESSING: 训练数据预处理中   * TRAINING_DATA_PREPROCESS_FAILED: 训练数据预处理失败   * TRAINING_DATA_PREPROCESS_SUCCESS: 训练数据预处理完成，等待训练资源中   * TRAINING: 训练中   * TRAIN_FAILED: 训练失败   * TRAIN_SUCCESS: 训练完成，等待预处理资源   * INFERENCE_DATA_PREPROCESSING: 推理数据预处理中   * INFERENCE_DATA_PREPROCESS_FAILED: 推理数据预处理失败   * WAIT_MAIN_FILE_UPLOAD: 等待主文件上传   * MANUAL_STOP_INFERENCE_DATA_PREPROCESS: 人工中止推理预处理   * MANUAL_STOP_TRAIN: 人工中止训练   * MANUAL_STOP_TRAINING_DATA_PREPROCESS: 人工中止训练预处理   * WAIT_ADMIN_CONFIRM: 等待管理员审核   * WAIT_COMPILE: 等待转编译   * COMPILING: 转编译中   * COMPILE_FAILED: 转编译失败   * WAIT_GENERATE_ACTION: 等待原子动作生成   * WAIT_ARRANGE: 等待编排   * ACTION_GENERATE_DATA_PROCESSING: 原子动作生成中   * MANUAL_STOP_ACTION_GENERATE_DATA_PROCESSING: 人工中止动作生成   * MANUAL_STOP_ACTION_GENERATE_ORI_PROCESSING: 人工中止动作编排   * ACTION_GENERATE_ORI_PROCESSING: 动作编排中   * ACTION_GENERATE_DATA_FAILED: 动作生成失败   * ACTION_GENERATE_ORI_FAILED: 生成动作编排资产失败   * ACTION_GENERATE_ORI_SUCCESS: 动作编排成功   * GENERATE_ACTION_PREPROCESS_FAILED: 生成动作编排原子动作失败   * WAIT_ADMIN_CALIBRATION: 等待管理员确认动作信息   * WAIT_ASSET_SYNC: 等待资产同步   * WAIT_GENERATE_ACTION_MARK 等待动作标定   * ACTION_MARKING: 动作标定生成 - 待用户审核，仅NA白名单用户有该状态   * WAIT_USER_CONFIRM: 等待用户确认训练效果  - 用户驳回，仅NA白名单用户有该状态   * JOB_REJECT: 驳回任务  - 已完成   * JOB_SUCCESS: 训练任务完成（普通用户任务的完成状态，此时用户已经可以使用模型）   * JOB_FINISH: 任务结束，是最终状态，不支持修改此状态(NA用户任务的完成状态，并且此状态表明模型效果已通过用户的验收)  - 挂起，仅NA白名单用户有该状态   * JOB_PENDING: 挂起任务   * WAIT_TEST_VIDEO_CHECK: 等待进行测试视频推理任务  * TEST_VIDEO_CHECK_PROCESSING：测试视频推理质量检测中  * TEST_VIDEO_CHECK_SUCCESS：测试视频推理质量检测通过  * TEST_VIDEO_CHECK_FAILED：测试视频推理质量检测未通过  * VIDEO_ANALYZE_PROCESSING：视频检测中  * VIDEO_ANALYZE_SUCCESS：视频检测通过  * VIDEO_ANALYZE_FAILED：视频检测未通过  * ACTION_MARKING：动作标定中  * ACTION_MARK_SUCCESS：动作标定成功  * ACTION_MARK_FAILED：动作标定失败  * ACTION_MARK_UPLOADED：动作标定文件上传成功  * MANUL_STOP_ACTION_MARK：中止动作标定
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 模型资产ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 模型资产所属项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 分身数字人模型封面下载URL。URL有效期24小时。
        /// </summary>
        [JsonProperty("cover_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverDownloadUrl { get; set; }

        /// <summary>
        /// 用户最近一次更新任务的时间（包括租户创建或者重新提交），格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 创建时间，格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 分身数字人训练任务创建者的手机号。
        /// </summary>
        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public string Contact { get; set; }

        /// <summary>
        /// 分身数字人训练任务的批次名称。
        /// </summary>
        [JsonProperty("batch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchName { get; set; }

        /// <summary>
        /// 分身数字人训练任务标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 分身数字人模型版本。默认是V3.2版本模型。 * V3.2：V3.2版本模型 * V3.3: 极速版flexus用的训练模型 &gt; * V3和V2版本已废弃不用
        /// </summary>
        [JsonProperty("model_version", NullValueHandling = NullValueHandling.Ignore)]
        public ModelVersionEnum ModelVersion { get; set; }
        /// <summary>
        /// 抠图类型。默认是AI。 * AI：AI抠图 * MANUAL：人工抠图
        /// </summary>
        [JsonProperty("matting_type", NullValueHandling = NullValueHandling.Ignore)]
        public MattingTypeEnum MattingType { get; set; }
        /// <summary>
        /// 分身数字人模型分辨率。默认是1080P。 * 1080P：1080P。支持1080P及720P的视频输出。 * 4K：4K。支持4K、1080P及720P的视频输出。
        /// </summary>
        [JsonProperty("model_resolution", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelResolution { get; set; }

        /// <summary>
        /// 自定义用户id（如创建任务时设置了X-App-UserId则会携带）。
        /// </summary>
        [JsonProperty("app_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppUserId { get; set; }

        /// <summary>
        /// 是否是基础版的形象训练
        /// </summary>
        [JsonProperty("is_flexus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFlexus { get; set; }

        /// <summary>
        /// 是否是直播间复刻任务
        /// </summary>
        [JsonProperty("is_live_copy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLiveCopy { get; set; }

        /// <summary>
        /// 是否极速版flexus
        /// </summary>
        [JsonProperty("is_fast_flexus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFastFlexus { get; set; }

        /// <summary>
        /// 是否只训练形象模型，不训练声音模型。仅Flexus版本时有效，默认false。
        /// </summary>
        [JsonProperty("is_only_human_model", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOnlyHumanModel { get; set; }

        /// <summary>
        /// 可选训练region
        /// </summary>
        [JsonProperty("optional_training_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OptionalTrainingLocation { get; set; }

        /// <summary>
        /// 分身数字人是否需要背景替换。需要背景替换的分身数字人训练视频需要绿幕拍摄。
        /// </summary>
        [JsonProperty("is_background_replacement", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBackgroundReplacement { get; set; }

        /// <summary>
        /// 是否按需任务
        /// </summary>
        [JsonProperty("is_ondemand_resource", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOndemandResource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainingJobBasicInfo {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  coverDownloadUrl: ").Append(CoverDownloadUrl).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  contact: ").Append(Contact).Append("\n");
            sb.Append("  batchName: ").Append(BatchName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  modelVersion: ").Append(ModelVersion).Append("\n");
            sb.Append("  mattingType: ").Append(MattingType).Append("\n");
            sb.Append("  modelResolution: ").Append(ModelResolution).Append("\n");
            sb.Append("  appUserId: ").Append(AppUserId).Append("\n");
            sb.Append("  isFlexus: ").Append(IsFlexus).Append("\n");
            sb.Append("  isLiveCopy: ").Append(IsLiveCopy).Append("\n");
            sb.Append("  isFastFlexus: ").Append(IsFastFlexus).Append("\n");
            sb.Append("  isOnlyHumanModel: ").Append(IsOnlyHumanModel).Append("\n");
            sb.Append("  optionalTrainingLocation: ").Append(OptionalTrainingLocation).Append("\n");
            sb.Append("  isBackgroundReplacement: ").Append(IsBackgroundReplacement).Append("\n");
            sb.Append("  isOndemandResource: ").Append(IsOndemandResource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrainingJobBasicInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrainingJobBasicInfo input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.State != input.State) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CoverDownloadUrl != input.CoverDownloadUrl || (this.CoverDownloadUrl != null && !this.CoverDownloadUrl.Equals(input.CoverDownloadUrl))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Contact != input.Contact || (this.Contact != null && !this.Contact.Equals(input.Contact))) return false;
            if (this.BatchName != input.BatchName || (this.BatchName != null && !this.BatchName.Equals(input.BatchName))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.ModelVersion != input.ModelVersion) return false;
            if (this.MattingType != input.MattingType) return false;
            if (this.ModelResolution != input.ModelResolution || (this.ModelResolution != null && !this.ModelResolution.Equals(input.ModelResolution))) return false;
            if (this.AppUserId != input.AppUserId || (this.AppUserId != null && !this.AppUserId.Equals(input.AppUserId))) return false;
            if (this.IsFlexus != input.IsFlexus || (this.IsFlexus != null && !this.IsFlexus.Equals(input.IsFlexus))) return false;
            if (this.IsLiveCopy != input.IsLiveCopy || (this.IsLiveCopy != null && !this.IsLiveCopy.Equals(input.IsLiveCopy))) return false;
            if (this.IsFastFlexus != input.IsFastFlexus || (this.IsFastFlexus != null && !this.IsFastFlexus.Equals(input.IsFastFlexus))) return false;
            if (this.IsOnlyHumanModel != input.IsOnlyHumanModel || (this.IsOnlyHumanModel != null && !this.IsOnlyHumanModel.Equals(input.IsOnlyHumanModel))) return false;
            if (this.OptionalTrainingLocation != input.OptionalTrainingLocation || (this.OptionalTrainingLocation != null && input.OptionalTrainingLocation != null && !this.OptionalTrainingLocation.SequenceEqual(input.OptionalTrainingLocation))) return false;
            if (this.IsBackgroundReplacement != input.IsBackgroundReplacement || (this.IsBackgroundReplacement != null && !this.IsBackgroundReplacement.Equals(input.IsBackgroundReplacement))) return false;
            if (this.IsOndemandResource != input.IsOndemandResource || (this.IsOndemandResource != null && !this.IsOndemandResource.Equals(input.IsOndemandResource))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CoverDownloadUrl != null) hashCode = hashCode * 59 + this.CoverDownloadUrl.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Contact != null) hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.BatchName != null) hashCode = hashCode * 59 + this.BatchName.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.ModelVersion.GetHashCode();
                hashCode = hashCode * 59 + this.MattingType.GetHashCode();
                if (this.ModelResolution != null) hashCode = hashCode * 59 + this.ModelResolution.GetHashCode();
                if (this.AppUserId != null) hashCode = hashCode * 59 + this.AppUserId.GetHashCode();
                if (this.IsFlexus != null) hashCode = hashCode * 59 + this.IsFlexus.GetHashCode();
                if (this.IsLiveCopy != null) hashCode = hashCode * 59 + this.IsLiveCopy.GetHashCode();
                if (this.IsFastFlexus != null) hashCode = hashCode * 59 + this.IsFastFlexus.GetHashCode();
                if (this.IsOnlyHumanModel != null) hashCode = hashCode * 59 + this.IsOnlyHumanModel.GetHashCode();
                if (this.OptionalTrainingLocation != null) hashCode = hashCode * 59 + this.OptionalTrainingLocation.GetHashCode();
                if (this.IsBackgroundReplacement != null) hashCode = hashCode * 59 + this.IsBackgroundReplacement.GetHashCode();
                if (this.IsOndemandResource != null) hashCode = hashCode * 59 + this.IsOndemandResource.GetHashCode();
                return hashCode;
            }
        }
    }
}
