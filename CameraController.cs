using UnityEngine;
using Cinemachine;

/// <summary>
/// An add-on module for Cinemachine Virtual Camera that locks the camera's X co-ordinate
/// </summary>
[ExecuteInEditMode]
[SaveDuringPlay]
[AddComponentMenu("")] // Hide in menu
public class CameraController : CinemachineExtension
{
    [Tooltip("Lock the camera's X position to this value")]
    public float m_YPosition = 0;

    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            pos.y = m_YPosition;
            state.RawPosition = pos;
        }
    }
}