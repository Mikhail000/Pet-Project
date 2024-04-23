using UnityEngine;

public class GameCursor 
{
    public static bool CursorVisible => Cursor.visible;
    public static Vector3 NormalizedPosition => new(Mathf.Clamp01(UnityEngine.Input.mousePosition.x / Screen.width), Mathf.Clamp01(UnityEngine.Input.mousePosition.y / Screen.height), 0);
    private static Camera Camera => SelectorData.Instance.Input.Provider.Camera;
    private static Ray CursorRay => SelectorData.Instance.Input.Provider.Camera.ViewportPointToRay(NormalizedPosition);
    private static LayerMask GroundLayer => SelectorData.Instance.Physics.GroundLayer;
    private static LayerMask UnitLayer => SelectorData.Instance.Physics.UnitLayer;
    
    public static bool TryGetSelectable(out ISelectable selectable)
    {
        selectable = null;
        var rayHit = UnityEngine.Physics.Raycast(CursorRay, out var hitInfo, Camera.farClipPlane, UnitLayer, QueryTriggerInteraction.Collide);
        if (rayHit && hitInfo.rigidbody) 
            selectable = hitInfo.rigidbody.GetComponent<ISelectable>();

        return rayHit && selectable != null;
    }
    
    public static bool GetNavMeshPoint(out Vector3 location, int navMesh = UnityEngine.AI.NavMesh.AllAreas)
    {
        location = Vector3.zero;
        if (GetGroundPoint(out var groundHitPoint) is false) 
            return false;
        if (UnityEngine.AI.NavMesh.SamplePosition(groundHitPoint, out var navMeshHitInfo, 100, navMesh) is false) 
            return false;
        location = navMeshHitInfo.position;
        return true;
    }
    
    private static bool GetGroundPoint(out Vector3 location)
    {
        location = Vector3.zero;
        var rayHit = UnityEngine.Physics.Raycast(CursorRay, out var hitInfo, Camera.farClipPlane, GroundLayer, QueryTriggerInteraction.Ignore);
        if (rayHit) location = hitInfo.point;
        return rayHit;
    }
}
