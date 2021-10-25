# ArchVis Tools
Support for all issues related to `ArchVisTools` on the Unreal Marketplace

![CineCameraCombined](https://github.com/Voulz/ArchVisTools/blob/main/Wiki/MarketingImages/CineCameraCombined.png)

## General Information

All the functionalities are written in the Wiki page: https://github.com/Voulz/ArchVisTools/wiki  
For issues, bugs and feature requests, please create an Issue: https://github.com/Voulz/ArchVisTools/issues  
For any other enquiry, you can email me at: voulz.git@gmail.com

Other Marketplace Content used for the images but not included in this pack:
- First Person Template by Epic Games
- [Soul: City](https://www.unrealengine.com/marketplace/en-US/product/soul-city) by Epic Games
- [Downtown West Modular Pack](https://www.unrealengine.com/marketplace/en-US/product/6bb93c7515e148a1a0a0ec263db67d5b) by PurePolygons


## Description
ArchVis Tools is a plugin which provides Camera Actors with added functionality useful for architecture rendering like an automatic vertical lines correction for 2-point perspectives.



### ArchVisCineCamera

![CineCameraCombined](https://github.com/Voulz/ArchVisTools/blob/main/Wiki/MarketingImages/CineCameraProcess.png)

This plugin features an `ArchVisCineCamera` which can automatically correct the view to look like a 2-point perspective (with the vertical lines being truly vertical). The strength of the correction can be adjusted as required. The `ArchVisCineCamera` also has an experimental feature where we can set a custom NearClippingPlane distance per camera, which is useful for interior shots.

There is also an experimental `ArchVisSceneCapture2D` which allows the rendering of an `ArchVisCineCamera` to a texture.

All the properties are accessible in Blueprint and can be animated in Sequencer.

### Movie Render Queue Passes

![MovieRenderQueue](https://github.com/Voulz/ArchVisTools/blob/main/Wiki/MarketingImages/MovieRenderQueue2.png)

To render the unique features of the `ArchVisCineCamera`, some custom `Movie Render Queue Passes` were created, based on the existing ones. The following are available:
- [ArchVis] Deferred Rendering
- [ArchVis] Deferred Rendering (Unlit)
- [ArchVis] Deferred Rendering (Detail Lighting)
- [ArchVis] Deferred Rendering (Lighting Only)
- [ArchVis] Deferred Rendering (Reflections Only)
- [ArchVis] Path Tracer

### Dataprep Operations

![Dataprep](https://github.com/Voulz/ArchVisTools/blob/main/Wiki/MarketingImages/Dataprep.png)

Custom Dataprep Operations were created to provide more functionality. The following are available:
- Branch Merge  [Operation]
- Build Adjacency  [Operation]
- Explode  [Operation]
- Face Camera  [Operation]
- Material Name  [Filter]
- Replace Camera  [Operation]
- Simplify Hierarchy  [Operation]
- Debug Operations  [Operation]


Full description of all the available features on the GitHub Wiki Page: https://github.com/Voulz/ArchVisTools/wiki



## Technical Information
**Features:**
- An `ArchVisCineCamera` which can automatically correct the view to look like a 2-point perspective.
- Custom `Movie Render Queue Passes` to handle the perspective correction.
- Custom `Dataprep Operations` to provide more functionality.
- Full description of all the available features on the GitHub Wiki Page.

**Code Modules:** 
- Module `ArchVisTools` [Runtime] containing `ArchVis CineCameraActor`, `ArchVis CineCameraComponent`, and custom `Movie Render Passes`.
- Module `ArchVisToolsEditor` [Editor] containing mostly `Dataprep Operations`

**Number of Blueprints:** 5 [Dataprep]

**Number of C++ Classes:** 10 [ArchVis Tools], 9 [AchVis Tools Editor]

**Network Replicated:** NA/Not tested

**Supported Development Platforms:** Successfully packaged for Windows and Mac, tested only on Windows.

**Documentation:** https://github.com/Voulz/ArchVisTools/wiki

**Example Project:** https://github.com/Voulz/ArchVisTools/wiki/Sample-File

**Important/Additional Notes:**  
This plugin has been developed and tested for ArchVis, using `Dataprep` for import, `Sequencer` for animation and `Movie Render Queue` for rendering. It should work fine for any other purpose (the plugin packages and works properly) but please contact me first if you have any particular use case in mind.  
The `Dataprep Operations` were made and tested for `Datasmith` files coming from `SketchUp`. They should work similarly with `Datasmith` files coming from other software but feel free to contact me first if you have any particular question.
