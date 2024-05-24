
# react-native-sikp-tally-helper

## Getting started

`$ npm install react-native-sikp-tally-helper --save`

### Mostly automatic installation

`$ react-native link react-native-sikp-tally-helper`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-sikp-tally-helper` and add `RNSikpTallyHelper.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNSikpTallyHelper.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNSikpTallyHelperPackage;` to the imports at the top of the file
  - Add `new RNSikpTallyHelperPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-sikp-tally-helper'
  	project(':react-native-sikp-tally-helper').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-sikp-tally-helper/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-sikp-tally-helper')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNSikpTallyHelper.sln` in `node_modules/react-native-sikp-tally-helper/windows/RNSikpTallyHelper.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Sikp.Tally.Helper.RNSikpTallyHelper;` to the usings at the top of the file
  - Add `new RNSikpTallyHelperPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNSikpTallyHelper from 'react-native-sikp-tally-helper';

// TODO: What to do with the module?
RNSikpTallyHelper;
```
  