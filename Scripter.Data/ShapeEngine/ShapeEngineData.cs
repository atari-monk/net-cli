namespace Scripter.Data;

public class ShapeEngineData 
    : IndependantLibData
{
    protected override void SetAllData()
    {
        base.SetAllData();
        ArgumentNullException.ThrowIfNull(Vector2);
        var simCore = Set(
            repo: "sim-core"
            , project:  "Sim.Core"
            , isApp: false
            , isWpf: true
            , libs: Vector2
            );
        var shapeModel = SetProjectDepsAndTests(
            repo: "shape-model"
            , project:  "Shape.Model"
            , isApp: false
            , isWpf: true
            , SetTests("Shape.Model.Tests")
            , Vector2
            , simCore
            );
        var canvas = Set(
            repo: "canvas"
            , project:  "Canvas"
            , isApp: false
            , isWpf: true
            , Vector2
            , simCore
            , shapeModel
            );
        var canvasApp = Set(
            repo: "canvas"
            , project:  "Canvas.App"
            , isApp: true
            , isWpf: true
            , Vector2
            , simCore
            , shapeModel
            );
        var poolResource = Set(
            repo: "pool-game"
            , project:  "Pool.Resource"
            );
        var poolPhysics = Set(
            repo: "pool-game"
            , project:  "Pool.Physic"
            , isApp: false
            , isWpf: true
            , Vector2
            , simCore
            );
        var poolLogic = Set(
            repo: "pool-game"
            , project:  "Pool.Logic"
            , isApp: false
            , isWpf: true
            , Vector2
            , simCore
            );
        var poolEngine = Set(
            repo: "pool-game"
            , project:  "Pool.Engine"
            , isApp: false
            , isWpf: true
            , Vector2
            , simCore
            );
        var poolControl = Set(
            repo: "pool-game"
            , project:  "Pool.Control"
            , isApp: false
            , isWpf: true
            , Vector2
            , simCore
            );
        var poolContainer = Set(
            repo: "pool-game"
            , project:  "Pool.Container"
            , isApp: false
            , isWpf: true
            , Vector2
            , simCore
            , canvas
            , shapeModel
            );
        var poolApp = Set(
            repo: "pool-game"
            , project:  "Pool.App"
            , isApp: true
            , isWpf: true
            , Vector2
            , simCore
            , canvas
            , shapeModel
            );
    }
}