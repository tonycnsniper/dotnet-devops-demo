import { Container, Box } from "@radix-ui/themes";
import "./App.css";
import Layout from "./components/Layout";
import MoveList from "./pages/movies/List";

function App() {
  return (
    <Container className="app w-full" size="4" align="center">
      <Layout>
        <MoveList />
      </Layout>
    </Container>
  );
}

export default App;
