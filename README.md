
# Cornea Palpation Simulator

This project is a simulation of the behavior of a cornea in response to deformation, developed in **Unity 3D** with **ANSYS** and a haptic device. It is designed for use in the medical field, allowing users (such as surgeons in training) to interact with a virtual environment to palpate the cornea and observe its physical and virtual behavior.

## Project Description

The project started with the simulation of the cornea in **ANSYS** to obtain all the necessary physics and equations. Once the physical modeling was completed, the simulation was transferred to **Unity** to take advantage of the haptic interface, allowing interaction with the cornea through the **Touch X** device.

The project is also **MQTT** compatible for communication between applications, enabling integration with other simulation systems or external data processing systems.

### Key Features
- **Cornea simulation in ANSYS**: Models the behavior of the cornea using various physical parameters, such as the elastic constant \( K \), obtained from the analysis of forces and displacements in ANSYS.
- **Interaction in Unity 3D**: The cornea model is transferred to Unity, where a deformable mesh is used to allow interaction via a haptic device.
- **Touch X Haptic Device**: Implemented with the **Touch X** haptic device, allowing users to "feel" the cornea through force feedback. To use this device, its software must be installed on the computer.
- **Real-time simulation**: The cornea deformation responds in real time to user interaction.
- **MQTT Compatibility**: The project is compatible with the MQTT protocol, facilitating integration with other applications or systems.

### Simulation Videos

- **ANSYS Simulation**: Below is a video of the cornea simulation performed in ANSYS, which demonstrates how the physics and deformation behavior of the cornea were modeled.

  https://github.com/user-attachments/assets/84272176-c423-4674-83da-0a183a19ebb0

- **Unity Simulation**: Below is a video of the cornea simulation in Unity, which shows how the haptic device interacts with the cornea in real-time, allowing users to palpate and feel the virtual model.

  https://github.com/user-attachments/assets/fbc2bdf9-e7bb-41ef-b015-a223a6b00329

### Video Note
The videos attached are demonstration videos, and the elastic constant \( K \) shown in the Unity video is not the real one, as it is a sample video to showcase the palpation of the mesh. However, the correct elastic constant \( K \) has been implemented in the full Unity project.

### Simulation Data
The **Cornea Excel.xlsx** file, which will be attached, contains data on the forces applied at various points during the cornea simulation in ANSYS. This data is crucial in determining which elastic constants to choose for the Unity simulation to ensure accurate cornea deformation modeling.

## System Requirements

- **Unity 3D**: Version 2021.3.11f1 (LTS).
- **ANSYS**: Version 2022 R2 to perform deformation calculations before use in Unity.
- **Visual Studio Code**: For editing and tracking the project.
- **Touch X Haptic Device**: For better interaction with the virtual environment.
- **Touch X Device Software**: Must be installed beforehand to ensure functionality with Unity.

## Project Structure

- `/Assets`: Contains all resources and scripts needed for the simulation in Unity.
- `/Scripts`: The main scripts for simulating the cornea and its deformation.
    - `CubeSphere.cs`: Generates the deformable mesh of the cornea.
    - `MeshDeformer.cs`: Applies deformations according to the calculated elastic constant.
    - `MeshDeformerInput.cs`: Controls user interaction with the mesh, applying deformation force.
- `/Ansys`: Files for the cornea model generated in ANSYS, along with the simulation results (mesh, displacements, etc.).
- `/Docs`: Additional project documentation, including this README.
- **Cornea Excel.xlsx**: Excel file containing the force data from various points in the ANSYS simulation of the cornea, which is used to determine the appropriate constants for Unity.

## Installation and Usage

1. **Clone the repository** to your local machine:
   ```bash
   git clone https://github.com/user/cornea-project.git
   ```

2. **Open in Unity**:
   - Open the project in Unity 2021.3.11f1 (LTS).

3. **Simulation in ANSYS** (Optional):
   - To modify or replicate the cornea's behavior, you can open the ANSYS file included in the `/Ansys` folder and perform additional simulations.

4. **Use with the Haptic Device**:
   - Connect the **Touch X** device and ensure the device's drivers and software are correctly installed.
   - Run the main scene in Unity and use the device to palpate the cornea.

## Contributions

If you would like to contribute to this project, you can fork the repository, make your changes, and submit a pull request. Please be sure to follow coding conventions and document any changes you make.

## License

This project is licensed under the [MIT License](LICENSE).
