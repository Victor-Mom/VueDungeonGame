using System;
using System.Collections.Generic;
using UnityEngine;

#region Tile Data

public enum EEffect { Asphalt, Sand, Mud, Ice, Concrete, Lava, Lightning, Poison }
public enum ETileType { Ground, Wall }

[Serializable]
public struct TileData
{
    public Sprite Sprite;
    public ETileType Type;
    public EEffect Effect;
}

#endregion

[CreateAssetMenu(menuName="CrazyDungeon/Room Generation Data")]
public class GameData : ScriptableObject
{
    [Header("Basic Shape")]
    [SerializeField] private Vector2Int m_minRoomSize = new Vector2Int(10, 10);
    [SerializeField] private Vector2Int m_maxRoomSize = new Vector2Int(40, 30);
    
    [Header("Corners Perlin Noises")]
    [SerializeField] private int m_minCornerPerlinSize = 3;
    [SerializeField] private int m_maxCornerPerlinSize = 10;
    [SerializeField, Range(0f, 1f)] private float m_cornerPerlinThreshold = 0.55f;
    [SerializeField] private bool m_displayDebugPerlinOnTilemap = true;
    [SerializeField] private bool m_displayDebugCellularOnTilemap = true;

    [Header("Cellular Modulation")]
    [SerializeField, Range(0, 100)] private int m_cellularModulationCount = 5;
    [SerializeField, Range(-1f, 1f)] private float m_trueTrue = 0.1f;
    [SerializeField, Range(-1f, 1f)] private float m_trueFalse = 0.1f;
    [SerializeField, Range(-1f, 1f)] private float m_falseFalse = 0.1f;
    [SerializeField, Range(-1f, 1f)] private float m_falseTrue = 0.1f;
    
    [Header("Tiles Data")]
    [SerializeField] private List<TileData> m_tiles = new List<TileData>();

    public Vector2Int MinRoomSize => m_minRoomSize;
    public Vector2Int MaxRoomSize => m_maxRoomSize;
    public int MinCornerPerlinSize => m_minCornerPerlinSize;
    public int MaxCornerPerlinSize => m_maxCornerPerlinSize;
    public float CornerPerlinThreshold => m_cornerPerlinThreshold;
    public bool DisplayDebugPerlinOnTilemap => m_displayDebugPerlinOnTilemap
    public bool DisplayDebugCellularOnTilemap => m_displayDebugCellularOnTilemap;
    public int CellularModulationCount => m_cellularModulationCount;
    public float TrueTrue => m_trueTrue;
    public float TrueFalse => m_trueFalse;
    public float FalseFalse => m_falseFalse;
    public float FalseTrue => m_falseTrue;
    public List<TileData> Tiles => m_tiles;
}