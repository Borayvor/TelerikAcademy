namespace CohesionAndCoupling
{
    using System;

    public static class UtilsFile
    {
        private const int lastIndex = -1;

        /// <summary>
        /// Get only extension of file.
        /// </summary>
        /// <param name="fileName">Full name of file as string.</param>
        /// <returns>Extension as string.</returns>
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");

            if(indexOfLastDot == lastIndex)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// Get file name without extension.
        /// </summary>
        /// <param name="fileName">Full name of file as string.</param>
        /// <returns>Name as string.</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");

            if(indexOfLastDot == lastIndex)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
