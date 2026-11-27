# FreeCAD Python console: exec(open(r"C:\path\extract_joint.py", encoding="utf-8").read())
import FreeCAD as App
joint = App.ActiveDocument.getObject("Joint")
if joint is None:
    raise ValueError("Joint object not found")
for i in (1, 2):
    link, subelements = getattr(joint, f"Reference{i}")
    local = getattr(joint, f"Placement{i}")
    placement = link.getGlobalPlacement() if hasattr(link, "getGlobalPlacement") else link.Placement
    world = placement.multiply(local)
    print(i, link.Name, subelements, world.Base, world.Rotation.multVec(App.Vector(0,0,1)))
# Check both axes and placement against the actual CAD assembly.
