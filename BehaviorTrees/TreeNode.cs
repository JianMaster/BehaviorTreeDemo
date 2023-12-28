namespace BehaviorTrees;

public abstract class TreeNode {
    private string name;
    protected TreeNode(string name) {
        this.name = name;
    }

    public abstract NodeStatus Tick();
}