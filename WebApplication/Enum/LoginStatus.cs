using GlobalResources;
using GlobalResources.Web.Enum;

namespace WebApplication.Enum
{
    /// <summary>
    /// 登入狀態
    /// </summary>
    public enum LoginStatus
    {
        /// <summary>
        /// 登入成功
        /// </summary>
        [LocalizedDescription("Logined", typeof(LoginStatusResource))]
        Logined = 0,

        /// <summary>
        /// 登入失敗
        /// </summary>
        [LocalizedDescription("Failed", typeof(LoginStatusResource))]
        Failed = 1,

        /// <summary>
        /// 登出
        /// </summary>
        [LocalizedDescription("Logout", typeof(LoginStatusResource))]
        Logout = 2,
    }
}