
# react-native-camera-roll-extended

## Getting started

`$ npm install react-native-camera-roll-extended --save`

### Mostly automatic installation

`$ react-native link react-native-camera-roll-extended`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-camera-roll-extended` and add `RNCameraRollExtended.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNCameraRollExtended.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNCameraRollExtendedPackage;` to the imports at the top of the file
  - Add `new RNCameraRollExtendedPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-camera-roll-extended'
  	project(':react-native-camera-roll-extended').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-camera-roll-extended/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-camera-roll-extended')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNCameraRollExtended.sln` in `node_modules/react-native-camera-roll-extended/windows/RNCameraRollExtended.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Camera.Roll.Extended.RNCameraRollExtended;` to the usings at the top of the file
  - Add `new RNCameraRollExtendedPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNCameraRollExtended from 'react-native-camera-roll-extended';

// TODO: What to do with the module?
RNCameraRollExtended;
```
  