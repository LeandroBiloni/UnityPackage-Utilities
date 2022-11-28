using UnityEngine;
using UnityEditor;

namespace Utilities.AssetDatabaseUtils
{
    public static class AssetRenamer
    {
        public static void RenameAsset(Object obj, string newName)
        {
            string path = AssetDatabase.GetAssetPath(obj);

            AssetDatabase.RenameAsset(path, newName);
            AssetDatabase.Refresh();
        }
    }
}
