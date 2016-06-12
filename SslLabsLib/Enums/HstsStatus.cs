namespace SslLabsLib.Enums
{
    public enum HstsStatus
    {
        /// <summary>
        /// either before the server is checked or when its HTTP response headers are not available
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// header not present
        /// </summary>
        Absent = 1,
        /// <summary>
        /// header present and syntatically correc
        /// </summary>
        Present = 2,
        /// <summary>
        /// header present, but couldn't be parsed
        /// </summary>
        Invalid = 4,
        /// <summary>
        /// header present and syntatically correct, but HSTS is disabled
        /// </summary>
        Disabled = 8
    }
}